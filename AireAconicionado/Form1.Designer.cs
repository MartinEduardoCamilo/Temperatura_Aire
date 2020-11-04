namespace AireAconicionado
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempAmbientenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TempAierenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.VentanacheckBox = new System.Windows.Forms.CheckBox();
            this.PuertacheckBox = new System.Windows.Forms.CheckBox();
            this.PuertaVentanacheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TiemponumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.EnfriamientotextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Generarbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IniciarcheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Limpiarbutton1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TempAmbientenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempAierenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiemponumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura Ambiente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura del aire acodicionado";
            // 
            // TempAmbientenumericUpDown
            // 
            this.TempAmbientenumericUpDown.Location = new System.Drawing.Point(21, 58);
            this.TempAmbientenumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.TempAmbientenumericUpDown.Name = "TempAmbientenumericUpDown";
            this.TempAmbientenumericUpDown.Size = new System.Drawing.Size(80, 22);
            this.TempAmbientenumericUpDown.TabIndex = 3;
            // 
            // TempAierenumericUpDown
            // 
            this.TempAierenumericUpDown.Location = new System.Drawing.Point(25, 121);
            this.TempAierenumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.TempAierenumericUpDown.Name = "TempAierenumericUpDown";
            this.TempAierenumericUpDown.Size = new System.Drawing.Size(87, 22);
            this.TempAierenumericUpDown.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Objetos abierto o cerrado";
            // 
            // VentanacheckBox
            // 
            this.VentanacheckBox.AutoSize = true;
            this.VentanacheckBox.Location = new System.Drawing.Point(25, 287);
            this.VentanacheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.VentanacheckBox.Name = "VentanacheckBox";
            this.VentanacheckBox.Size = new System.Drawing.Size(83, 21);
            this.VentanacheckBox.TabIndex = 7;
            this.VentanacheckBox.Text = "Ventana";
            this.VentanacheckBox.UseVisualStyleBackColor = true;
            this.VentanacheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VentanacheckBox_MouseClick);
            // 
            // PuertacheckBox
            // 
            this.PuertacheckBox.AutoSize = true;
            this.PuertacheckBox.Location = new System.Drawing.Point(123, 287);
            this.PuertacheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.PuertacheckBox.Name = "PuertacheckBox";
            this.PuertacheckBox.Size = new System.Drawing.Size(72, 21);
            this.PuertacheckBox.TabIndex = 8;
            this.PuertacheckBox.Text = "Puerta";
            this.PuertacheckBox.UseVisualStyleBackColor = true;
            this.PuertacheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PuertacheckBox_MouseClick);
            // 
            // PuertaVentanacheckBox
            // 
            this.PuertaVentanacheckBox.AutoSize = true;
            this.PuertaVentanacheckBox.Location = new System.Drawing.Point(207, 287);
            this.PuertaVentanacheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.PuertaVentanacheckBox.Name = "PuertaVentanacheckBox";
            this.PuertaVentanacheckBox.Size = new System.Drawing.Size(140, 21);
            this.PuertaVentanacheckBox.TabIndex = 9;
            this.PuertaVentanacheckBox.Text = "Puerta y Ventana";
            this.PuertaVentanacheckBox.UseVisualStyleBackColor = true;
            this.PuertaVentanacheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PuertaVentanacheckBox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tiempo en minutos";
            // 
            // TiemponumericUpDown
            // 
            this.TiemponumericUpDown.Location = new System.Drawing.Point(25, 196);
            this.TiemponumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.TiemponumericUpDown.Name = "TiemponumericUpDown";
            this.TiemponumericUpDown.Size = new System.Drawing.Size(87, 22);
            this.TiemponumericUpDown.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tiempo de enfriamiento";
            // 
            // EnfriamientotextBox
            // 
            this.EnfriamientotextBox.Location = new System.Drawing.Point(185, 332);
            this.EnfriamientotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnfriamientotextBox.Name = "EnfriamientotextBox";
            this.EnfriamientotextBox.Size = new System.Drawing.Size(132, 22);
            this.EnfriamientotextBox.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Generarbutton
            // 
            this.Generarbutton.Location = new System.Drawing.Point(12, 396);
            this.Generarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Generarbutton.Name = "Generarbutton";
            this.Generarbutton.Size = new System.Drawing.Size(100, 44);
            this.Generarbutton.TabIndex = 17;
            this.Generarbutton.Text = "Generar";
            this.Generarbutton.UseVisualStyleBackColor = true;
            this.Generarbutton.Click += new System.EventHandler(this.Generarbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IniciarcheckBox
            // 
            this.IniciarcheckBox.AutoSize = true;
            this.IniciarcheckBox.Location = new System.Drawing.Point(185, 409);
            this.IniciarcheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IniciarcheckBox.Name = "IniciarcheckBox";
            this.IniciarcheckBox.Size = new System.Drawing.Size(81, 21);
            this.IniciarcheckBox.TabIndex = 18;
            this.IniciarcheckBox.Text = "Prender";
            this.IniciarcheckBox.UseVisualStyleBackColor = true;
            this.IniciarcheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IniciarcheckBox_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(576, 357);
            this.dataGridView1.TabIndex = 19;
            // 
            // Limpiarbutton1
            // 
            this.Limpiarbutton1.Location = new System.Drawing.Point(13, 466);
            this.Limpiarbutton1.Name = "Limpiarbutton1";
            this.Limpiarbutton1.Size = new System.Drawing.Size(99, 43);
            this.Limpiarbutton1.TabIndex = 20;
            this.Limpiarbutton1.Text = "Limpiar";
            this.Limpiarbutton1.UseVisualStyleBackColor = true;
            this.Limpiarbutton1.Click += new System.EventHandler(this.Limpiarbutton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Estado del Aire.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(359, 462);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 21);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Encendido";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(359, 509);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(87, 21);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Apagado";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Limpiarbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IniciarcheckBox);
            this.Controls.Add(this.Generarbutton);
            this.Controls.Add(this.EnfriamientotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TiemponumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PuertaVentanacheckBox);
            this.Controls.Add(this.PuertacheckBox);
            this.Controls.Add(this.VentanacheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TempAierenumericUpDown);
            this.Controls.Add(this.TempAmbientenumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TempAmbientenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempAierenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiemponumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TempAmbientenumericUpDown;
        private System.Windows.Forms.NumericUpDown TempAierenumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox VentanacheckBox;
        private System.Windows.Forms.CheckBox PuertacheckBox;
        private System.Windows.Forms.CheckBox PuertaVentanacheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TiemponumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EnfriamientotextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Generarbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox IniciarcheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Limpiarbutton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

