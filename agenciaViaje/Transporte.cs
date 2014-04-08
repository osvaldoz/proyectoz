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
    public partial class Transporte : Form
    {
        public Transporte()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string error = "";
            pbxImagenCarro.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                switch (listBoxCarros.SelectedItem.ToString())
                {
                    case "VW Clasico":
                        pbxImagenCarro.Image = global::agenciaViaje.Properties.Resources.vw_clasico;

                        
                       //pbxImagenCarro.Image = Image.FromFile("/Imagenes//vw-clasico.jpg");
                       // OpenFileDialog OPFD = new OpenFileDialog();
                        //OPFD.InitialDirectory = "c:\\";
                    //    PictureBox picBox = new PictureBox();                     
                    //    picBox.Width = 100;
                    //    picBox.Height = 100;

                    //    Bitmap image = new Bitmap("C:\\Users\\Osvaldo\\Desktop\\Escuela\\SW enf a negocios\\agenciaViaje\\agenciaViaje\\Imagenes\\vw-clasico.jpg");
                    //    picBox.Dock = DockStyle.Fill;
                    //    picBox.Image = (Image)image;

                    //    Controls.Add(picBox);
                        break;
                    case "Dodge RAM":
                        pbxImagenCarro.Image = global::agenciaViaje.Properties.Resources.dodge_ram_pickup;
                      
                        break;
                    case "Dodge Caravan":
                        pbxImagenCarro.Image = global::agenciaViaje.Properties.Resources.dodge_caravan;
                        pbxImagenCarro.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rdBtnCamioneta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Transporte_Load(object sender, EventArgs e)
        {

        }

        private void rdBtnSedan_CheckedChanged(object sender, EventArgs e)
        {
            listBoxCarros.Items.Clear();
            listBoxCarros.Items.Add("VW Clasico");
            listBoxCarros.Items.Add("Nissan March");
            listBoxCarros.Items.Add("Ford Focus");
            listBoxCarros.Items.Add("Chevrolet Cruze");
            listBoxCarros.Items.Add("Honda Civic");
        }

        private void rdBtnCamioneta_CheckedChanged_1(object sender, EventArgs e)
        {
            listBoxCarros.Items.Clear();
            listBoxCarros.Items.Add("Dodge Caravan");
            listBoxCarros.Items.Add("Ford Windstar");
            listBoxCarros.Items.Add("Honda Odyssey");
        }

        private void rdBtnTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            listBoxCarros.Items.Clear();
            listBoxCarros.Items.Add("Dodge RAM");
            listBoxCarros.Items.Add("Ford Lobo");
            listBoxCarros.Items.Add("Chevrolet Cheyenne");
            listBoxCarros.Items.Add("VW Amarok");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
