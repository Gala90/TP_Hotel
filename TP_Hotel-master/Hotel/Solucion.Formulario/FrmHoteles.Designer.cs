namespace Solucion.Formulario
{
    partial class FrmHoteles
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
            this.btnAltaHotel = new System.Windows.Forms.Button();
            this.btnBajaHotel = new System.Windows.Forms.Button();
            this.btnModifHotel = new System.Windows.Forms.Button();
            this.btnVolverHotel = new System.Windows.Forms.Button();
            this.BtnConsulHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaHotel
            // 
            this.btnAltaHotel.Location = new System.Drawing.Point(74, 52);
            this.btnAltaHotel.Name = "btnAltaHotel";
            this.btnAltaHotel.Size = new System.Drawing.Size(174, 23);
            this.btnAltaHotel.TabIndex = 0;
            this.btnAltaHotel.Text = "Alta";
            this.btnAltaHotel.UseVisualStyleBackColor = true;
            // 
            // btnBajaHotel
            // 
            this.btnBajaHotel.Location = new System.Drawing.Point(74, 104);
            this.btnBajaHotel.Name = "btnBajaHotel";
            this.btnBajaHotel.Size = new System.Drawing.Size(174, 23);
            this.btnBajaHotel.TabIndex = 1;
            this.btnBajaHotel.Text = "Baja";
            this.btnBajaHotel.UseVisualStyleBackColor = true;
            // 
            // btnModifHotel
            // 
            this.btnModifHotel.Location = new System.Drawing.Point(74, 159);
            this.btnModifHotel.Name = "btnModifHotel";
            this.btnModifHotel.Size = new System.Drawing.Size(174, 23);
            this.btnModifHotel.TabIndex = 2;
            this.btnModifHotel.Text = "Modificacion";
            this.btnModifHotel.UseVisualStyleBackColor = true;
            // 
            // btnVolverHotel
            // 
            this.btnVolverHotel.Location = new System.Drawing.Point(26, 300);
            this.btnVolverHotel.Name = "btnVolverHotel";
            this.btnVolverHotel.Size = new System.Drawing.Size(75, 23);
            this.btnVolverHotel.TabIndex = 3;
            this.btnVolverHotel.Text = "Volver";
            this.btnVolverHotel.UseVisualStyleBackColor = true;
            // 
            // BtnConsulHotel
            // 
            this.BtnConsulHotel.Location = new System.Drawing.Point(74, 219);
            this.BtnConsulHotel.Name = "BtnConsulHotel";
            this.BtnConsulHotel.Size = new System.Drawing.Size(174, 23);
            this.BtnConsulHotel.TabIndex = 4;
            this.BtnConsulHotel.Text = "Consulta";
            this.BtnConsulHotel.UseVisualStyleBackColor = true;
            // 
            // FrmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 359);
            this.Controls.Add(this.BtnConsulHotel);
            this.Controls.Add(this.btnVolverHotel);
            this.Controls.Add(this.btnModifHotel);
            this.Controls.Add(this.btnBajaHotel);
            this.Controls.Add(this.btnAltaHotel);
            this.Name = "FrmHoteles";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaHotel;
        private System.Windows.Forms.Button btnBajaHotel;
        private System.Windows.Forms.Button btnModifHotel;
        private System.Windows.Forms.Button btnVolverHotel;
        private System.Windows.Forms.Button BtnConsulHotel;
    }
}