
namespace LinqToEntities
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTraerTodosAutores = new System.Windows.Forms.Button();
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.gridPublicadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraerTodosPublicadores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTraerAutoresPorCiudad = new System.Windows.Forms.Button();
            this.btnTraerAutoresPorId = new System.Windows.Forms.Button();
            this.btnTraerPublicadorPorNombre = new System.Windows.Forms.Button();
            this.btnTraerListaTiendas = new System.Windows.Forms.Button();
            this.gridListas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraerEmpleadosPublicadores = new System.Windows.Forms.Button();
            this.btnTraerMismoPais = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublicadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosAutores
            // 
            this.btnTraerTodosAutores.Location = new System.Drawing.Point(7, 80);
            this.btnTraerTodosAutores.Name = "btnTraerTodosAutores";
            this.btnTraerTodosAutores.Size = new System.Drawing.Size(166, 23);
            this.btnTraerTodosAutores.TabIndex = 0;
            this.btnTraerTodosAutores.Text = "Traer todos";
            this.btnTraerTodosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutores.Click += new System.EventHandler(this.btnTraerTodosAutores_Click);
            // 
            // gridAutores
            // 
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Location = new System.Drawing.Point(7, 191);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(300, 150);
            this.gridAutores.TabIndex = 1;
            // 
            // gridPublicadores
            // 
            this.gridPublicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublicadores.Location = new System.Drawing.Point(324, 191);
            this.gridPublicadores.Name = "gridPublicadores";
            this.gridPublicadores.Size = new System.Drawing.Size(300, 150);
            this.gridPublicadores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autores";
            // 
            // btnTraerTodosPublicadores
            // 
            this.btnTraerTodosPublicadores.Location = new System.Drawing.Point(324, 80);
            this.btnTraerTodosPublicadores.Name = "btnTraerTodosPublicadores";
            this.btnTraerTodosPublicadores.Size = new System.Drawing.Size(166, 23);
            this.btnTraerTodosPublicadores.TabIndex = 4;
            this.btnTraerTodosPublicadores.Text = "Traer todos";
            this.btnTraerTodosPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerTodosPublicadores.Click += new System.EventHandler(this.btnTraerTodosPublicadores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Publicadores";
            // 
            // btnTraerAutoresPorCiudad
            // 
            this.btnTraerAutoresPorCiudad.Location = new System.Drawing.Point(7, 109);
            this.btnTraerAutoresPorCiudad.Name = "btnTraerAutoresPorCiudad";
            this.btnTraerAutoresPorCiudad.Size = new System.Drawing.Size(166, 23);
            this.btnTraerAutoresPorCiudad.TabIndex = 6;
            this.btnTraerAutoresPorCiudad.Text = "Traer por ciudad";
            this.btnTraerAutoresPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerAutoresPorCiudad.Click += new System.EventHandler(this.btnTraerAutoresPorCiudad_Click);
            // 
            // btnTraerAutoresPorId
            // 
            this.btnTraerAutoresPorId.Location = new System.Drawing.Point(7, 138);
            this.btnTraerAutoresPorId.Name = "btnTraerAutoresPorId";
            this.btnTraerAutoresPorId.Size = new System.Drawing.Size(166, 23);
            this.btnTraerAutoresPorId.TabIndex = 7;
            this.btnTraerAutoresPorId.Text = "Traer autor por ID";
            this.btnTraerAutoresPorId.UseVisualStyleBackColor = true;
            this.btnTraerAutoresPorId.Click += new System.EventHandler(this.btnTraerAutorPorId_Click);
            // 
            // btnTraerPublicadorPorNombre
            // 
            this.btnTraerPublicadorPorNombre.Location = new System.Drawing.Point(324, 109);
            this.btnTraerPublicadorPorNombre.Name = "btnTraerPublicadorPorNombre";
            this.btnTraerPublicadorPorNombre.Size = new System.Drawing.Size(166, 23);
            this.btnTraerPublicadorPorNombre.TabIndex = 8;
            this.btnTraerPublicadorPorNombre.Text = "Traer publicador por nombre";
            this.btnTraerPublicadorPorNombre.UseVisualStyleBackColor = true;
            this.btnTraerPublicadorPorNombre.Click += new System.EventHandler(this.btnTraerPublicadorPorNombre_Click);
            // 
            // btnTraerListaTiendas
            // 
            this.btnTraerListaTiendas.Location = new System.Drawing.Point(641, 80);
            this.btnTraerListaTiendas.Name = "btnTraerListaTiendas";
            this.btnTraerListaTiendas.Size = new System.Drawing.Size(166, 23);
            this.btnTraerListaTiendas.TabIndex = 9;
            this.btnTraerListaTiendas.Text = "Traer tiendas";
            this.btnTraerListaTiendas.UseVisualStyleBackColor = true;
            this.btnTraerListaTiendas.Click += new System.EventHandler(this.btnTraerListaTiendas_Click);
            // 
            // gridListas
            // 
            this.gridListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListas.Location = new System.Drawing.Point(641, 191);
            this.gridListas.Name = "gridListas";
            this.gridListas.Size = new System.Drawing.Size(300, 150);
            this.gridListas.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Listas";
            // 
            // btnTraerEmpleadosPublicadores
            // 
            this.btnTraerEmpleadosPublicadores.Location = new System.Drawing.Point(641, 109);
            this.btnTraerEmpleadosPublicadores.Name = "btnTraerEmpleadosPublicadores";
            this.btnTraerEmpleadosPublicadores.Size = new System.Drawing.Size(166, 23);
            this.btnTraerEmpleadosPublicadores.TabIndex = 12;
            this.btnTraerEmpleadosPublicadores.Text = "Traer empleados/publicadores";
            this.btnTraerEmpleadosPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerEmpleadosPublicadores.Click += new System.EventHandler(this.btnTraerEmpleadosPublicadores_Click);
            // 
            // btnTraerMismoPais
            // 
            this.btnTraerMismoPais.Location = new System.Drawing.Point(641, 138);
            this.btnTraerMismoPais.Name = "btnTraerMismoPais";
            this.btnTraerMismoPais.Size = new System.Drawing.Size(166, 23);
            this.btnTraerMismoPais.TabIndex = 13;
            this.btnTraerMismoPais.Text = "Traer e/p por país";
            this.btnTraerMismoPais.UseVisualStyleBackColor = true;
            this.btnTraerMismoPais.Click += new System.EventHandler(this.btnTraerMismoPais_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(496, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(179, 112);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(128, 20);
            this.txtCiudad.TabIndex = 15;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(179, 141);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 20);
            this.txtID.TabIndex = 16;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(813, 140);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(128, 20);
            this.txtPais.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnTraerMismoPais);
            this.Controls.Add(this.btnTraerEmpleadosPublicadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridListas);
            this.Controls.Add(this.btnTraerListaTiendas);
            this.Controls.Add(this.btnTraerPublicadorPorNombre);
            this.Controls.Add(this.btnTraerAutoresPorId);
            this.Controls.Add(this.btnTraerAutoresPorCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTraerTodosPublicadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPublicadores);
            this.Controls.Add(this.gridAutores);
            this.Controls.Add(this.btnTraerTodosAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublicadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosAutores;
        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.DataGridView gridPublicadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraerTodosPublicadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTraerAutoresPorCiudad;
        private System.Windows.Forms.Button btnTraerAutoresPorId;
        private System.Windows.Forms.Button btnTraerPublicadorPorNombre;
        private System.Windows.Forms.Button btnTraerListaTiendas;
        private System.Windows.Forms.DataGridView gridListas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTraerEmpleadosPublicadores;
        private System.Windows.Forms.Button btnTraerMismoPais;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPais;
    }
}