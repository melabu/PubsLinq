﻿
namespace WindowsPubs
{
    partial class frmAutores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.btnFiltrarPorCiudad = new System.Windows.Forms.Button();
            this.txtFiltrarPorCiudad = new System.Windows.Forms.TextBox();
            this.txtFiltrarPorCiudadYEstado = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorCiudadYEstado = new System.Windows.Forms.Button();
            this.txtFiltrarPorCiudadYEstado2 = new System.Windows.Forms.TextBox();
            this.Ciudad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAutores
            // 
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAutores.Location = new System.Drawing.Point(0, 131);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(800, 319);
            this.gridAutores.TabIndex = 0;
            // 
            // btnFiltrarPorCiudad
            // 
            this.btnFiltrarPorCiudad.Location = new System.Drawing.Point(376, 34);
            this.btnFiltrarPorCiudad.Name = "btnFiltrarPorCiudad";
            this.btnFiltrarPorCiudad.Size = new System.Drawing.Size(113, 23);
            this.btnFiltrarPorCiudad.TabIndex = 1;
            this.btnFiltrarPorCiudad.Text = "Filtrar por Ciudad";
            this.btnFiltrarPorCiudad.UseVisualStyleBackColor = true;
            this.btnFiltrarPorCiudad.Click += new System.EventHandler(this.btnFiltrarPorCiudad_Click);
            // 
            // txtFiltrarPorCiudad
            // 
            this.txtFiltrarPorCiudad.Location = new System.Drawing.Point(251, 37);
            this.txtFiltrarPorCiudad.Name = "txtFiltrarPorCiudad";
            this.txtFiltrarPorCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrarPorCiudad.TabIndex = 3;
            // 
            // txtFiltrarPorCiudadYEstado
            // 
            this.txtFiltrarPorCiudadYEstado.Location = new System.Drawing.Point(251, 63);
            this.txtFiltrarPorCiudadYEstado.Name = "txtFiltrarPorCiudadYEstado";
            this.txtFiltrarPorCiudadYEstado.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrarPorCiudadYEstado.TabIndex = 4;
            // 
            // btnFiltrarPorCiudadYEstado
            // 
            this.btnFiltrarPorCiudadYEstado.Location = new System.Drawing.Point(376, 66);
            this.btnFiltrarPorCiudadYEstado.Name = "btnFiltrarPorCiudadYEstado";
            this.btnFiltrarPorCiudadYEstado.Size = new System.Drawing.Size(113, 39);
            this.btnFiltrarPorCiudadYEstado.TabIndex = 5;
            this.btnFiltrarPorCiudadYEstado.Text = "Filtrar por Ciudad y Estado";
            this.btnFiltrarPorCiudadYEstado.UseVisualStyleBackColor = true;
            this.btnFiltrarPorCiudadYEstado.Click += new System.EventHandler(this.btnFiltrarPorCiudadYEstado_Click);
            // 
            // txtFiltrarPorCiudadYEstado2
            // 
            this.txtFiltrarPorCiudadYEstado2.Location = new System.Drawing.Point(251, 85);
            this.txtFiltrarPorCiudadYEstado2.Name = "txtFiltrarPorCiudadYEstado2";
            this.txtFiltrarPorCiudadYEstado2.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrarPorCiudadYEstado2.TabIndex = 6;
            // 
            // Ciudad
            // 
            this.Ciudad.AutoSize = true;
            this.Ciudad.Location = new System.Drawing.Point(180, 66);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(40, 13);
            this.Ciudad.TabIndex = 7;
            this.Ciudad.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estado";
            // 
            // frmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ciudad);
            this.Controls.Add(this.txtFiltrarPorCiudadYEstado2);
            this.Controls.Add(this.btnFiltrarPorCiudadYEstado);
            this.Controls.Add(this.txtFiltrarPorCiudadYEstado);
            this.Controls.Add(this.txtFiltrarPorCiudad);
            this.Controls.Add(this.btnFiltrarPorCiudad);
            this.Controls.Add(this.gridAutores);
            this.Name = "frmAutores";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Button btnFiltrarPorCiudad;
        private System.Windows.Forms.TextBox txtFiltrarPorCiudad;
        private System.Windows.Forms.TextBox txtFiltrarPorCiudadYEstado;
        private System.Windows.Forms.Button btnFiltrarPorCiudadYEstado;
        private System.Windows.Forms.TextBox txtFiltrarPorCiudadYEstado2;
        private System.Windows.Forms.Label Ciudad;
        private System.Windows.Forms.Label label1;
    }
}

