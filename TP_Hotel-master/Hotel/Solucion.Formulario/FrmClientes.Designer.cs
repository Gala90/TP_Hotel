namespace Solucion.Formulario
{
    partial class FrmClientes
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
            this.BtnAltaCliente = new System.Windows.Forms.Button();
            this.BtnConsutaCliente = new System.Windows.Forms.Button();
            this.BtnVolverCliente = new System.Windows.Forms.Button();
            this.btnModifCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAltaCliente
            // 
            this.BtnAltaCliente.Location = new System.Drawing.Point(244, 38);
            this.BtnAltaCliente.Name = "BtnAltaCliente";
            this.BtnAltaCliente.Size = new System.Drawing.Size(131, 45);
            this.BtnAltaCliente.TabIndex = 0;
            this.BtnAltaCliente.Text = "Alta";
            this.BtnAltaCliente.UseVisualStyleBackColor = true;
            // 
            // BtnConsutaCliente
            // 
            this.BtnConsutaCliente.Location = new System.Drawing.Point(244, 249);
            this.BtnConsutaCliente.Name = "BtnConsutaCliente";
            this.BtnConsutaCliente.Size = new System.Drawing.Size(131, 42);
            this.BtnConsutaCliente.TabIndex = 1;
            this.BtnConsutaCliente.Text = "Consulta";
            this.BtnConsutaCliente.UseVisualStyleBackColor = true;
            // 
            // BtnVolverCliente
            // 
            this.BtnVolverCliente.Location = new System.Drawing.Point(602, 293);
            this.BtnVolverCliente.Name = "BtnVolverCliente";
            this.BtnVolverCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnVolverCliente.TabIndex = 3;
            this.BtnVolverCliente.Text = "Volver";
            this.BtnVolverCliente.UseVisualStyleBackColor = true;
            // 
            // btnModifCliente
            // 
            this.btnModifCliente.Location = new System.Drawing.Point(244, 132);
            this.btnModifCliente.Name = "btnModifCliente";
            this.btnModifCliente.Size = new System.Drawing.Size(131, 52);
            this.btnModifCliente.TabIndex = 4;
            this.btnModifCliente.Text = "Modificar";
            this.btnModifCliente.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifCliente);
            this.Controls.Add(this.BtnVolverCliente);
            this.Controls.Add(this.BtnConsutaCliente);
            this.Controls.Add(this.BtnAltaCliente);
            this.Name = "FrmClientes";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAltaCliente;
        private System.Windows.Forms.Button BtnConsutaCliente;
        private System.Windows.Forms.Button BtnVolverCliente;
        private System.Windows.Forms.Button btnModifCliente;
    }
}