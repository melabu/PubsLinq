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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void mostrarAutores()
        {
            gridAutor.DataSource = AdmAuthor.Listar();
        }

        private void llenarComboCiudad()
        {
            DataTable Ciudad = AdmAuthor.listar();
            cbCiudad.DataSource = Ciudad;
            cbCiudad.DisplayMember = Ciudad.Columns["CategoryName"].ToString();
            cbCiudad.ValueMember = Ciudad.Columns["CategoryID"].ToString();

            //Agregar una fila al DataTable "Categoria" en memoria
            DataRow fila = Ciudad.NewRow();
            fila["CategoryID"] = 0;
            fila["CategoryName"] = "[TODAS]"; Ciudad.Rows.InsertAt(fila, 0);

        }


        private void frmAutor_Load(object sender, EventArgs e)
        {
           mostrarAutores();
           llenarComboCiudad();
        }
    }
}
