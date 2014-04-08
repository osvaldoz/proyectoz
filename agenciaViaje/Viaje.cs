using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenciaViaje
{
    public partial class Viaje : Form
    {
        Conexion con = new Conexion();
        variablesGlobales var = new variablesGlobales();
        public Viaje()
        {
         
            InitializeComponent();
            cmbEstadoOrigen = con.regresaCombo("SELECT text=nombre,value=estadoId FROM estados ", cmbEstadoOrigen);
            cmbEstadoOrigen.SelectedIndex = cmbEstadoOrigen.FindString("Hermosillo");
            cmbEstadoDestino = con.regresaCombo("SELECT text=nombre,value=estadoId FROM estados", cmbEstadoDestino);
            cmbEstadoDestino.SelectedIndex = cmbEstadoDestino.FindString("Hermosillo");
        }

        private void Viaje_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            variablesGlobales.nombreParametros = new string[7];
            variablesGlobales.parametros = new string[7];

            variablesGlobales.nombreParametros[0] = "@origenId"; variablesGlobales.parametros[0] = var.valorSeleccionado(cmbOrigen);
            variablesGlobales.nombreParametros[1] = "@destinoId"; variablesGlobales.parametros[1] = var.valorSeleccionado(cmbDestino);
            variablesGlobales.nombreParametros[2] = "@salida"; variablesGlobales.parametros[2] = dtSalida.Value.ToString("yyyy-MM-dd") + " " + dtTimeS.Value.ToString("HH:mm");
            variablesGlobales.nombreParametros[3] = "@origen"; variablesGlobales.parametros[3] = dtRegreso.Value.ToString("yyyy-MM-dd") + " " + dtTimeR.Value.ToString("HH:mm");
            variablesGlobales.nombreParametros[4] = "@clase"; variablesGlobales.parametros[4] = "Primera Clase";
            variablesGlobales.nombreParametros[5] = "@adultos"; variablesGlobales.parametros[5] = nAdultos.Value.ToString();
            variablesGlobales.nombreParametros[6] = "@menores"; variablesGlobales.parametros[6] = nMenores.Value.ToString();

            //variablesGlobales.nombreParametros[2] = "@generacionId";



            //  variablesGlobales.parametros[2] = var.valorSeleccionado(cmbGeneracion);


            if (con.ejecutaSP("insertaVuelo", variablesGlobales.nombreParametros, variablesGlobales.parametros, 2) == true)
            {
                MessageBox.Show("Vuelo reservado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al intentar guardar la reservacion: " + variablesGlobales.mensajeErrorSQL);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstadoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOrigen.Items.Clear();
            cmbOrigen = con.regresaCombo("SELECT text=nombre,value=ciudadId FROM ciudades WHERE estadoId="+var.valorSeleccionado(cmbEstadoOrigen), cmbOrigen);
            cmbOrigen.SelectedIndex = cmbOrigen.FindString("Hermosillo");
        }

        private void cmbEstadoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDestino.Items.Clear();
            cmbDestino = con.regresaCombo("SELECT text=nombre,value=ciudadId FROM ciudades WHERE estadoId=" + var.valorSeleccionado(cmbEstadoDestino), cmbDestino);
            cmbDestino.SelectedIndex = cmbDestino.FindString("Hermosillo");
        }

      
        
    }
}
