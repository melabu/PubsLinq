using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Admin;

namespace WindowsPubs
{
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void btnFiltrarPorCiudad_Click(object sender, EventArgs e)
        {
            String city = txtFiltrarPorCiudad.Text;

            gridAutores.DataSource = AdmAuthor.Listar(city);
        }

        private void btnFiltrarPorCiudadYEstado_Click(object sender, EventArgs e)
        {
            String city = txtFiltrarPorCiudadYEstado.Text;
            String state = txtFiltrarPorCiudadYEstado2.Text;

            gridAutores.DataSource = AdmAuthor.Listar(city, state);
        }
    }
}
