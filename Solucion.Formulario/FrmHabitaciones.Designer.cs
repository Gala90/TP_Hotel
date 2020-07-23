namespace Solucion.Formulario
{
    partial class FrmHabitaciones
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolverHotel = new System.Windows.Forms.Button();
            this.btnAltaHotel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 251);
            this.listBox1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Habitaciones";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hotel";
            // 
            // btnVolverHotel
            // 
            this.btnVolverHotel.Location = new System.Drawing.Point(26, 475);
            this.btnVolverHotel.Name = "btnVolverHotel";
            this.btnVolverHotel.Size = new System.Drawing.Size(88, 34);
            this.btnVolverHotel.TabIndex = 40;
            this.btnVolverHotel.Text = "Volver";
            this.btnVolverHotel.UseVisualStyleBackColor = true;
            this.btnVolverHotel.Click += new System.EventHandler(this.btnVolverHotel_Click);
            // 
            // btnAltaHotel
            // 
            this.btnAltaHotel.Location = new System.Drawing.Point(48, 404);
            this.btnAltaHotel.Name = "btnAltaHotel";
            this.btnAltaHotel.Size = new System.Drawing.Size(454, 43);
            this.btnAltaHotel.TabIndex = 37;
            this.btnAltaHotel.Text = "Alta";
            this.btnAltaHotel.UseVisualStyleBackColor = true;
            this.btnAltaHotel.Click += new System.EventHandler(this.btnAltaHotel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 20);
            this.textBox1.TabIndex = 42;
            // 
            // FrmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 540);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVolverHotel);
            this.Controls.Add(this.btnAltaHotel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Name = "FrmHabitaciones";
            this.Text = "FrmHabitaciones";
            this.Load += new System.EventHandler(this.FrmHabitaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVolverHotel;
        private System.Windows.Forms.Button btnAltaHotel;
        private System.Windows.Forms.TextBox textBox1;
    }
}