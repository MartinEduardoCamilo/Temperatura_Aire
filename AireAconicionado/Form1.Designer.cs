﻿namespace AireAconicionado
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
            this.EncendidocheckBox = new System.Windows.Forms.CheckBox();
            this.ApagadocheckBox = new System.Windows.Forms.CheckBox();
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
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura Ambiente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura del aire acodicionado";
            // 
            // TempAmbientenumericUpDown
            // 
            this.TempAmbientenumericUpDown.Location = new System.Drawing.Point(16, 47);
            this.TempAmbientenumericUpDown.Name = "TempAmbientenumericUpDown";
            this.TempAmbientenumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.TempAmbientenumericUpDown.TabIndex = 3;
            // 
            // TempAierenumericUpDown
            // 
            this.TempAierenumericUpDown.Location = new System.Drawing.Point(19, 98);
            this.TempAierenumericUpDown.Name = "TempAierenumericUpDown";
            this.TempAierenumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.TempAierenumericUpDown.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Objetos abierto o cerrado";
            // 
            // VentanacheckBox
            // 
            this.VentanacheckBox.AutoSize = true;
            this.VentanacheckBox.Location = new System.Drawing.Point(19, 233);
            this.VentanacheckBox.Name = "VentanacheckBox";
            this.VentanacheckBox.Size = new System.Drawing.Size(66, 17);
            this.VentanacheckBox.TabIndex = 7;
            this.VentanacheckBox.Text = "Ventana";
            this.VentanacheckBox.UseVisualStyleBackColor = true;
            this.VentanacheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VentanacheckBox_MouseClick);
            // 
            // PuertacheckBox
            // 
            this.PuertacheckBox.AutoSize = true;
            this.PuertacheckBox.Location = new System.Drawing.Point(92, 233);
            this.PuertacheckBox.Name = "PuertacheckBox";
            this.PuertacheckBox.Size = new System.Drawing.Size(57, 17);
            this.PuertacheckBox.TabIndex = 8;
            this.PuertacheckBox.Text = "Puerta";
            this.PuertacheckBox.UseVisualStyleBackColor = true;
            this.PuertacheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PuertacheckBox_MouseClick);
            // 
            // PuertaVentanacheckBox
            // 
            this.PuertaVentanacheckBox.AutoSize = true;
            this.PuertaVentanacheckBox.Location = new System.Drawing.Point(155, 233);
            this.PuertaVentanacheckBox.Name = "PuertaVentanacheckBox";
            this.PuertaVentanacheckBox.Size = new System.Drawing.Size(108, 17);
            this.PuertaVentanacheckBox.TabIndex = 9;
            this.PuertaVentanacheckBox.Text = "Puerta y Ventana";
            this.PuertaVentanacheckBox.UseVisualStyleBackColor = true;
            this.PuertaVentanacheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PuertaVentanacheckBox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tiempo en segundos";
            // 
            // TiemponumericUpDown
            // 
            this.TiemponumericUpDown.Location = new System.Drawing.Point(19, 159);
            this.TiemponumericUpDown.Name = "TiemponumericUpDown";
            this.TiemponumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.TiemponumericUpDown.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tiempo de enfriamiento";
            // 
            // EnfriamientotextBox
            // 
            this.EnfriamientotextBox.Location = new System.Drawing.Point(139, 270);
            this.EnfriamientotextBox.Name = "EnfriamientotextBox";
            this.EnfriamientotextBox.Size = new System.Drawing.Size(100, 20);
            this.EnfriamientotextBox.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Generarbutton
            // 
            this.Generarbutton.Location = new System.Drawing.Point(9, 322);
            this.Generarbutton.Name = "Generarbutton";
            this.Generarbutton.Size = new System.Drawing.Size(75, 36);
            this.Generarbutton.TabIndex = 17;
            this.Generarbutton.Text = "Conectar";
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
            this.IniciarcheckBox.Location = new System.Drawing.Point(139, 332);
            this.IniciarcheckBox.Name = "IniciarcheckBox";
            this.IniciarcheckBox.Size = new System.Drawing.Size(63, 17);
            this.IniciarcheckBox.TabIndex = 18;
            this.IniciarcheckBox.Text = "Prender";
            this.IniciarcheckBox.UseVisualStyleBackColor = true;
            this.IniciarcheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IniciarcheckBox_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(432, 290);
            this.dataGridView1.TabIndex = 19;
            // 
            // Limpiarbutton1
            // 
            this.Limpiarbutton1.Location = new System.Drawing.Point(10, 379);
            this.Limpiarbutton1.Margin = new System.Windows.Forms.Padding(2);
            this.Limpiarbutton1.Name = "Limpiarbutton1";
            this.Limpiarbutton1.Size = new System.Drawing.Size(74, 35);
            this.Limpiarbutton1.TabIndex = 20;
            this.Limpiarbutton1.Text = "Limpiar";
            this.Limpiarbutton1.UseVisualStyleBackColor = true;
            this.Limpiarbutton1.Click += new System.EventHandler(this.Limpiarbutton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Estado del Aire.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 379);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 23;
            // 
            // EncendidocheckBox
            // 
            this.EncendidocheckBox.AutoSize = true;
            this.EncendidocheckBox.Location = new System.Drawing.Point(269, 375);
            this.EncendidocheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.EncendidocheckBox.Name = "EncendidocheckBox";
            this.EncendidocheckBox.Size = new System.Drawing.Size(77, 17);
            this.EncendidocheckBox.TabIndex = 25;
            this.EncendidocheckBox.Text = "Encendido";
            this.EncendidocheckBox.UseVisualStyleBackColor = true;
            // 
            // ApagadocheckBox
            // 
            this.ApagadocheckBox.AutoSize = true;
            this.ApagadocheckBox.Location = new System.Drawing.Point(269, 414);
            this.ApagadocheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ApagadocheckBox.Name = "ApagadocheckBox";
            this.ApagadocheckBox.Size = new System.Drawing.Size(69, 17);
            this.ApagadocheckBox.TabIndex = 26;
            this.ApagadocheckBox.Text = "Apagado";
            this.ApagadocheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApagadocheckBox);
            this.Controls.Add(this.EncendidocheckBox);
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
        private System.Windows.Forms.CheckBox ApagadocheckBox;
        private System.Windows.Forms.CheckBox EncendidocheckBox;
    }
}

