﻿namespace Solucion.Formulario
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
            this.BtnVolverCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnAltaCliente
            // 
            this.BtnAltaCliente.Location = new System.Drawing.Point(65, 380);
            this.BtnAltaCliente.Name = "BtnAltaCliente";
            this.BtnAltaCliente.Size = new System.Drawing.Size(450, 50);
            this.BtnAltaCliente.TabIndex = 0;
            this.BtnAltaCliente.Text = "Alta";
            this.BtnAltaCliente.UseVisualStyleBackColor = true;
            this.BtnAltaCliente.Click += new System.EventHandler(this.BtnAltaCliente_Click);
            // 
            // BtnVolverCliente
            // 
            this.BtnVolverCliente.Location = new System.Drawing.Point(24, 466);
            this.BtnVolverCliente.Name = "BtnVolverCliente";
            this.BtnVolverCliente.Size = new System.Drawing.Size(105, 37);
            this.BtnVolverCliente.TabIndex = 3;
            this.BtnVolverCliente.Text = "Volver";
            this.BtnVolverCliente.UseVisualStyleBackColor = true;
            this.BtnVolverCliente.Click += new System.EventHandler(this.BtnVolverCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Clientes";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(507, 277);
            this.listBox1.TabIndex = 31;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 532);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnVolverCliente);
            this.Controls.Add(this.BtnAltaCliente);
            this.Name = "FrmClientes";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAltaCliente;
        private System.Windows.Forms.Button BtnVolverCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
    }
}