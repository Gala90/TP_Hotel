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
            this.btnVolverHotel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaHotel
            // 
            this.btnAltaHotel.Location = new System.Drawing.Point(46, 349);
            this.btnAltaHotel.Name = "btnAltaHotel";
            this.btnAltaHotel.Size = new System.Drawing.Size(454, 43);
            this.btnAltaHotel.TabIndex = 0;
            this.btnAltaHotel.Text = "Alta";
            this.btnAltaHotel.UseVisualStyleBackColor = true;
            this.btnAltaHotel.Click += new System.EventHandler(this.btnAltaHotel_Click);
            // 
            // btnVolverHotel
            // 
            this.btnVolverHotel.Location = new System.Drawing.Point(26, 508);
            this.btnVolverHotel.Name = "btnVolverHotel";
            this.btnVolverHotel.Size = new System.Drawing.Size(88, 34);
            this.btnVolverHotel.TabIndex = 3;
            this.btnVolverHotel.Text = "Volver";
            this.btnVolverHotel.UseVisualStyleBackColor = true;
            this.btnVolverHotel.Click += new System.EventHandler(this.btnVolverHotel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Hoteles";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 251);
            this.listBox1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "Habitaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVolverHotel);
            this.Controls.Add(this.btnAltaHotel);
            this.Name = "FrmHoteles";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmHoteles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaHotel;
        private System.Windows.Forms.Button btnVolverHotel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}