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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TempAmbientenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TempAierenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TempEscapenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.VentanacheckBox = new System.Windows.Forms.CheckBox();
            this.PuertacheckBox = new System.Windows.Forms.CheckBox();
            this.PuertaVentanacheckBox = new System.Windows.Forms.CheckBox();
            this.Garficachart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TempAmbientenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempAierenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempEscapenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garficachart)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura del aire escapandose";
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
            // TempEscapenumericUpDown
            // 
            this.TempEscapenumericUpDown.Location = new System.Drawing.Point(19, 151);
            this.TempEscapenumericUpDown.Name = "TempEscapenumericUpDown";
            this.TempEscapenumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.TempEscapenumericUpDown.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Objetos abierto o cerrado";
            // 
            // VentanacheckBox
            // 
            this.VentanacheckBox.AutoSize = true;
            this.VentanacheckBox.Location = new System.Drawing.Point(19, 230);
            this.VentanacheckBox.Name = "VentanacheckBox";
            this.VentanacheckBox.Size = new System.Drawing.Size(66, 17);
            this.VentanacheckBox.TabIndex = 7;
            this.VentanacheckBox.Text = "Ventana";
            this.VentanacheckBox.UseVisualStyleBackColor = true;
            // 
            // PuertacheckBox
            // 
            this.PuertacheckBox.AutoSize = true;
            this.PuertacheckBox.Location = new System.Drawing.Point(92, 230);
            this.PuertacheckBox.Name = "PuertacheckBox";
            this.PuertacheckBox.Size = new System.Drawing.Size(57, 17);
            this.PuertacheckBox.TabIndex = 8;
            this.PuertacheckBox.Text = "Puerta";
            this.PuertacheckBox.UseVisualStyleBackColor = true;
            // 
            // PuertaVentanacheckBox
            // 
            this.PuertaVentanacheckBox.AutoSize = true;
            this.PuertaVentanacheckBox.Location = new System.Drawing.Point(155, 230);
            this.PuertaVentanacheckBox.Name = "PuertaVentanacheckBox";
            this.PuertaVentanacheckBox.Size = new System.Drawing.Size(108, 17);
            this.PuertaVentanacheckBox.TabIndex = 9;
            this.PuertaVentanacheckBox.Text = "Puerta y Ventana";
            this.PuertaVentanacheckBox.UseVisualStyleBackColor = true;
            // 
            // Garficachart
            // 
            chartArea1.Name = "ChartArea1";
            this.Garficachart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Garficachart.Legends.Add(legend1);
            this.Garficachart.Location = new System.Drawing.Point(269, 12);
            this.Garficachart.Name = "Garficachart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Garficachart.Series.Add(series1);
            this.Garficachart.Size = new System.Drawing.Size(519, 394);
            this.Garficachart.TabIndex = 10;
            this.Garficachart.Text = "chart1";
            this.Garficachart.Click += new System.EventHandler(this.Garficachart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Garficachart);
            this.Controls.Add(this.PuertaVentanacheckBox);
            this.Controls.Add(this.PuertacheckBox);
            this.Controls.Add(this.VentanacheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TempEscapenumericUpDown);
            this.Controls.Add(this.TempAierenumericUpDown);
            this.Controls.Add(this.TempAmbientenumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TempAmbientenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempAierenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempEscapenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garficachart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TempAmbientenumericUpDown;
        private System.Windows.Forms.NumericUpDown TempAierenumericUpDown;
        private System.Windows.Forms.NumericUpDown TempEscapenumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox VentanacheckBox;
        private System.Windows.Forms.CheckBox PuertacheckBox;
        private System.Windows.Forms.CheckBox PuertaVentanacheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Garficachart;
    }
}

