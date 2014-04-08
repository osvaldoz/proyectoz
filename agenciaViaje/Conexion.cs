using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenciaViaje
{
    class Conexion
    {

        string cadena = variablesGlobales.cadena;
        int i = 0;

       
        
        public bool Nonquery(string coman)
        {
            SqlConnection conectar = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand(coman, conectar);
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                conectar.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception x)
            {
                variablesGlobales.mensajeErrorSQL = x.Message;
                return false;
            }
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
        }

        public DataSet regresaTabla(string SP, string[] nombreParametros, string[] Parametros)
        {
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();
            SqlParameter param;
            DataSet ds = new DataSet();
            connection = new SqlConnection(cadena);

            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = SP;
            while (i == nombreParametros.Length)
            {
                param = new SqlParameter(nombreParametros[i], Parametros[i]);
                param.Direction = ParameterDirection.Input;
                param.DbType = DbType.String;
                command.Parameters.Add(param);
            }
            adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            connection.Close();
            return ds;
        }


        public bool ejecutaSP(string SP, string[] nombreParametros, string[] Parametros, int tipo)
        {
            i = 0;
            variablesGlobales.ds = null;
            try
            {
                //SqlConnection connection;
                SqlConnection connection = new SqlConnection(cadena);
                SqlCommand command = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                SqlParameter param;
                DataSet ds = new DataSet();


                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = SP;
                while (i != nombreParametros.Length)
                {
                    if (nombreParametros[i] != null)
                    {
                        param = new SqlParameter(nombreParametros[i], Parametros[i]);
                        param.Direction = ParameterDirection.Input;
                        param.DbType = DbType.String;
                        command.Parameters.Add(param);
                    }
                    i++;
                }

                if (tipo == 1)
                {
                    adapter.Fill(ds, "Tabla");
                    variablesGlobales.ds = ds;
                }
                else
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();

                return true;
            }
            catch (Exception e)
            {
                variablesGlobales.mensajeErrorSQL = e.Message;
                return false;
            }
        }

        public DataSet regresaTabla(string consulta)
        {
            SqlConnection conectar = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            conectar.Open();
            comando.ExecuteNonQuery();
            da.Fill(ds, "Tabla");
            conectar.Close();
            return ds;
        }


        //public DataSet regresaTabla(string consulta)
        //{
        //    SqlConnection conectar = new SqlConnection(cadena);
        //    SqlCommand comando = new SqlCommand(consulta, conectar);
        //    SqlDataAdapter da = new SqlDataAdapter(comando);
        //    DataSet ds = new DataSet();
        //    conectar.Open();
        //    comando.ExecuteNonQuery();
        //    da.Fill(ds, "Tabla");
        //    conectar.Close();
        //    return ds;
        //}

        public ComboBox regresaCombo(string consulta, ComboBox cmb)
        {
            variablesGlobales.ds = null;
            variablesGlobales.dt = null;
            ComboboxItem item = new ComboboxItem();
            SqlConnection conectar = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            conectar.Open();
            comando.ExecuteNonQuery();
            da.Fill(ds, "Tabla");
            conectar.Close();

            variablesGlobales.dt = ds.Tables["tabla"];
            foreach (DataRow dr in variablesGlobales.dt.Rows)
            {
                // MessageBox.Show(dr["nombre"].ToString());
                item = new ComboboxItem();
                item.Text = dr["text"].ToString();
                item.Value = dr["value"].ToString();
                cmb.Items.Add(item);

            }
            return cmb;
        }
    }
}
