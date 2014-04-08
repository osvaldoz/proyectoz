using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenciaViaje
{
    class variablesGlobales
    {
        public static string[] parametros;
        public static string[] nombreParametros;
        public static DataSet ds;
        public static DataTable dt;
        public static string mensajeErrorSQL;
        public static string cadena = @"Data Source=admin\oz;Initial Catalog=agenciaViajes;Persist Security Info=True;User ID=user ;Password=0";

        public static ComboBox cmb;
        public static Conexion con = new Conexion();
        public static ComboBox cmbCiudad()
        {
            cmb = con.regresaCombo("SELECT text='TODAS',value=-1 UNION ALL SELECT text=nombre,value=ciudadId FROM ciudades WHERE estadoId=26", cmb);           
            return cmb;
        }

        public string valorSeleccionado(ComboBox cmb)
        {
            //  MessageBox.Show(cmb.FindString(cmb.Text).ToString());


            try
            {
                return (cmb.SelectedItem as ComboboxItem).Value.ToString();
            }
            catch
            {

                return "0";
            }
        }

       
    }
}
