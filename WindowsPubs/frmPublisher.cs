using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Servidor;

namespace WindowsPubs
{
    public partial class frmPublisher : Form
    {
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String city = txtFiltrarPorCiudad2.Text;

            gridPublisher.DataSource = AdmPublisher.Listar(city);
        }

        private void btnFiltrarPorCiudadYEstado2_Click(object sender, EventArgs e)
        {
            String city = txtFiltrarPorCiudadYEstado3.Text;
            String state = txtFiltrarPorCiudadYEstado4.Text;

            gridPublisher.DataSource = AdmPublisher.Listar(city, state);
        }

        private void btnFiltrarPorCiudadEstadoPais_Click(object sender, EventArgs e)
        {
            String city = txtFiltrarPorCiudadEstadoPais.Text;
            String state = txtFiltrarPorCiudadEstadoPais2.Text;
            String country = txtFiltrarPorCiudadEstadoPais3.Text;

            gridPublisher.DataSource = AdmPublisher.Listar(city, state, country);
        }
    }
}
