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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            transicion t = new transicion(cbGuia.Checked, cbViaje.Checked, cbSeguros.Checked, cbTransporte.Checked, cbHotel.Checked);
        }
    }
}
