using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToEntities.Datos;

namespace LinqToEntities
{
    public partial class Form1 : Form
    {
        //crear una instancia del dbcontext
        PubsContext context = new PubsContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            var lista = (from a in context.authors
                         select a).ToList();

            gridAutores.DataSource = lista;
        }

        private void btnTraerTodosPublicadores_Click(object sender, EventArgs e)
        {
            var lista = (from p in context.publishers
                         select p).ToList();

            gridPublicadores.DataSource = lista;
        }

        private void btnTraerAutoresPorCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;

            var autores = (from a in context.authors
                           where a.city == ciudad
                           select a).ToList();
            gridAutores.DataSource = autores;
        }

        private void btnTraerAutorPorId_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            var autor = (from a in context.authors
                         where a.au_id == id
                         select a).ToList();
            gridAutores.DataSource = autor;
        }

        private void btnTraerPublicadorPorNombre_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            var publicador = (from p in context.publishers
                              where p.pub_name == nombre
                              select p).ToList();
            gridPublicadores.DataSource = publicador;
        }

        private void btnTraerListaTiendas_Click(object sender, EventArgs e)
        {
            var lista = (
                        from
                        sale in context.sales
                        join
                        store in context.stores
                        on sale.stor_id equals store.stor_id
                        select new
                        {
                            ID=sale.stor_id,
                            NombreTienda=store.stor_name,
                            Ciudad=store.city,
                            NroOrden=sale.ord_num,
                            Fecha=sale.ord_date,
                            Cantidad=sale.qty,
                            Titulo=sale.title
                        }
                ).ToList();

            gridListas.DataSource = lista;
        }

        private void btnTraerEmpleadosPublicadores_Click(object sender, EventArgs e)
        {
            var lista = (
                        from
                        employee in context.employees
                        join
                        p in context.publishers
                        on employee.pub_id equals p.pub_id
                        select new
                        {
                            Nombre = employee.fname,
                            Apellido = employee.lname,
                            Publicador = p.pub_name,
                        }
                ).ToList();

            gridListas.DataSource = lista;
        }

        private void btnTraerMismoPais_Click(object sender, EventArgs e)
        {
            string pais = txtPais.Text;
            var lista = (
                        from
                        employee in context.employees
                        join
                        p in context.publishers
                        on employee.pub_id equals p.pub_id
                        where p.country == pais
                        select new
                        {
                            Nombre = employee.fname,
                            Apellido = employee.lname,
                            Publicador = p.pub_name,
                        }
                ).ToList();

            gridListas.DataSource = lista;
        }
    }
}
