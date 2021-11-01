
namespace WindowsPubs
{
    partial class frmAutor
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
            this.gridAutor = new System.Windows.Forms.DataGridView();
            this.btnTraerPorCiudad = new System.Windows.Forms.Button();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAutor
            // 
            this.gridAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAutor.Location = new System.Drawing.Point(0, 143);
            this.gridAutor.Name = "gridAutor";
            this.gridAutor.Size = new System.Drawing.Size(800, 307);
            this.gridAutor.TabIndex = 0;
            // 
            // btnTraerPorCiudad
            // 
            this.btnTraerPorCiudad.Location = new System.Drawing.Point(247, 88);
            this.btnTraerPorCiudad.Name = "btnTraerPorCiudad";
            this.btnTraerPorCiudad.Size = new System.Drawing.Size(105, 23);
            this.btnTraerPorCiudad.TabIndex = 1;
            this.btnTraerPorCiudad.Text = "Traer Por Ciudad";
            this.btnTraerPorCiudad.UseVisualStyleBackColor = true;
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.IntegralHeight = false;
            this.cbCiudad.Location = new System.Drawing.Point(370, 90);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(141, 21);
            this.cbCiudad.TabIndex = 2;
            // 
            // frmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.btnTraerPorCiudad);
            this.Controls.Add(this.gridAutor);
            this.Name = "frmAutor";
            this.Text = "frmAutor";
            this.Load += new System.EventHandler(this.frmAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAutor;
        private System.Windows.Forms.Button btnTraerPorCiudad;
        private System.Windows.Forms.ComboBox cbCiudad;
    }
}