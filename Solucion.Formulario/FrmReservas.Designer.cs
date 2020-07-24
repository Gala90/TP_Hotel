namespace Solucion.Formulario
{
    partial class FrmReservas
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
            this.BtnAltaReserva = new System.Windows.Forms.Button();
            this.BtnVolverReserva = new System.Windows.Forms.Button();
            this.btnBajaReserva = new System.Windows.Forms.Button();
            this.btnModifReserva = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnAltaReserva
            // 
            this.BtnAltaReserva.Location = new System.Drawing.Point(58, 396);
            this.BtnAltaReserva.Name = "BtnAltaReserva";
            this.BtnAltaReserva.Size = new System.Drawing.Size(476, 46);
            this.BtnAltaReserva.TabIndex = 0;
            this.BtnAltaReserva.Text = "Crear";
            this.BtnAltaReserva.UseVisualStyleBackColor = true;
            this.BtnAltaReserva.Click += new System.EventHandler(this.BtnAltaReserva_Click);
            // 
            // BtnVolverReserva
            // 
            this.BtnVolverReserva.Location = new System.Drawing.Point(12, 598);
            this.BtnVolverReserva.Name = "BtnVolverReserva";
            this.BtnVolverReserva.Size = new System.Drawing.Size(87, 26);
            this.BtnVolverReserva.TabIndex = 3;
            this.BtnVolverReserva.Text = "Volver";
            this.BtnVolverReserva.UseVisualStyleBackColor = true;
            this.BtnVolverReserva.Click += new System.EventHandler(this.BtnVolverReserva_Click);
            // 
            // btnBajaReserva
            // 
            this.btnBajaReserva.Location = new System.Drawing.Point(58, 463);
            this.btnBajaReserva.Name = "btnBajaReserva";
            this.btnBajaReserva.Size = new System.Drawing.Size(476, 45);
            this.btnBajaReserva.TabIndex = 4;
            this.btnBajaReserva.Text = "Cancelar";
            this.btnBajaReserva.UseVisualStyleBackColor = true;
            this.btnBajaReserva.Click += new System.EventHandler(this.btnBajaReserva_Click);
            // 
            // btnModifReserva
            // 
            this.btnModifReserva.Location = new System.Drawing.Point(58, 527);
            this.btnModifReserva.Name = "btnModifReserva";
            this.btnModifReserva.Size = new System.Drawing.Size(476, 45);
            this.btnModifReserva.TabIndex = 5;
            this.btnModifReserva.Text = "Modificar";
            this.btnModifReserva.UseVisualStyleBackColor = true;
            this.btnModifReserva.Click += new System.EventHandler(this.btnModifReserva_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Reservas";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 316);
            this.listBox1.TabIndex = 33;
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 636);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModifReserva);
            this.Controls.Add(this.btnBajaReserva);
            this.Controls.Add(this.BtnVolverReserva);
            this.Controls.Add(this.BtnAltaReserva);
            this.Name = "FrmReservas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAltaReserva;
        private System.Windows.Forms.Button BtnVolverReserva;
        private System.Windows.Forms.Button btnBajaReserva;
        private System.Windows.Forms.Button btnModifReserva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
    }
}