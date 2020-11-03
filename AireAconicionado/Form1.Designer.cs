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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempAmbientenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TempAierenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.VentanacheckBox = new System.Windows.Forms.CheckBox();
            this.PuertacheckBox = new System.Windows.Forms.CheckBox();
            this.PuertaVentanacheckBox = new System.Windows.Forms.CheckBox();
            this.Graficachart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Iniciarbutton = new System.Windows.Forms.Button();
            this.Pararbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TiemponumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.EnfriamientotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TempAmbientenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempAierenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graficachart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiemponumericUpDown)).BeginInit();
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
            // 
            // Graficachart
            // 
            chartArea1.Name = "ChartArea1";
            this.Graficachart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graficachart.Legends.Add(legend1);
            this.Graficachart.Location = new System.Drawing.Point(269, 12);
            this.Graficachart.Name = "Graficachart";
            this.Graficachart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Graficachart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Aqua,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))))};
            this.Graficachart.Size = new System.Drawing.Size(519, 394);
            this.Graficachart.TabIndex = 10;
            this.Graficachart.Text = "chart1";
            // 
            // Iniciarbutton
            // 
            this.Iniciarbutton.Location = new System.Drawing.Point(19, 322);
            this.Iniciarbutton.Name = "Iniciarbutton";
            this.Iniciarbutton.Size = new System.Drawing.Size(75, 23);
            this.Iniciarbutton.TabIndex = 11;
            this.Iniciarbutton.Text = "Iniciar";
            this.Iniciarbutton.UseVisualStyleBackColor = true;
            this.Iniciarbutton.Click += new System.EventHandler(this.Iniciarbutton_Click);
            // 
            // Pararbutton
            // 
            this.Pararbutton.Location = new System.Drawing.Point(109, 322);
            this.Pararbutton.Name = "Pararbutton";
            this.Pararbutton.Size = new System.Drawing.Size(75, 23);
            this.Pararbutton.TabIndex = 12;
            this.Pararbutton.Text = "Parar";
            this.Pararbutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tiempo en minutos";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnfriamientotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TiemponumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pararbutton);
            this.Controls.Add(this.Iniciarbutton);
            this.Controls.Add(this.Graficachart);
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
            ((System.ComponentModel.ISupportInitialize)(this.Graficachart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiemponumericUpDown)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart Graficachart;
        private System.Windows.Forms.Button Iniciarbutton;
        private System.Windows.Forms.Button Pararbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TiemponumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EnfriamientotextBox;
    }
}

