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
            this.label4 = new System.Windows.Forms.Label();
            this.VentanacheckBox = new System.Windows.Forms.CheckBox();
            this.PuertacheckBox = new System.Windows.Forms.CheckBox();
            this.PuertaVentanacheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnfriamientotextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EncendidocheckBox = new System.Windows.Forms.CheckBox();
            this.ApagadocheckBox = new System.Windows.Forms.CheckBox();
            this.SuspencioncheckBox = new System.Windows.Forms.CheckBox();
            this.TempEncendidotextBox = new System.Windows.Forms.TextBox();
            this.TempApagadotextBox = new System.Windows.Forms.TextBox();
            this.TiempotextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Iniciarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura detectada por el sensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura de Apagado del Aire ";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(377, 290);
            this.dataGridView1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 313);
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
            this.EncendidocheckBox.Location = new System.Drawing.Point(16, 345);
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
            this.ApagadocheckBox.Location = new System.Drawing.Point(97, 345);
            this.ApagadocheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ApagadocheckBox.Name = "ApagadocheckBox";
            this.ApagadocheckBox.Size = new System.Drawing.Size(69, 17);
            this.ApagadocheckBox.TabIndex = 26;
            this.ApagadocheckBox.Text = "Apagado";
            this.ApagadocheckBox.UseVisualStyleBackColor = true;
            // 
            // SuspencioncheckBox
            // 
            this.SuspencioncheckBox.AutoSize = true;
            this.SuspencioncheckBox.Location = new System.Drawing.Point(171, 345);
            this.SuspencioncheckBox.Name = "SuspencioncheckBox";
            this.SuspencioncheckBox.Size = new System.Drawing.Size(82, 17);
            this.SuspencioncheckBox.TabIndex = 27;
            this.SuspencioncheckBox.Text = "Suspención";
            this.SuspencioncheckBox.UseVisualStyleBackColor = true;
            // 
            // TempEncendidotextBox
            // 
            this.TempEncendidotextBox.Location = new System.Drawing.Point(19, 48);
            this.TempEncendidotextBox.Name = "TempEncendidotextBox";
            this.TempEncendidotextBox.Size = new System.Drawing.Size(100, 20);
            this.TempEncendidotextBox.TabIndex = 28;
            // 
            // TempApagadotextBox
            // 
            this.TempApagadotextBox.Location = new System.Drawing.Point(19, 109);
            this.TempApagadotextBox.Name = "TempApagadotextBox";
            this.TempApagadotextBox.Size = new System.Drawing.Size(100, 20);
            this.TempApagadotextBox.TabIndex = 29;
            // 
            // TiempotextBox
            // 
            this.TiempotextBox.Location = new System.Drawing.Point(19, 171);
            this.TiempotextBox.Name = "TiempotextBox";
            this.TiempotextBox.Size = new System.Drawing.Size(100, 20);
            this.TiempotextBox.TabIndex = 30;
            // 
            // Iniciarbutton
            // 
            this.Iniciarbutton.Location = new System.Drawing.Point(346, 345);
            this.Iniciarbutton.Name = "Iniciarbutton";
            this.Iniciarbutton.Size = new System.Drawing.Size(75, 23);
            this.Iniciarbutton.TabIndex = 31;
            this.Iniciarbutton.Text = "Iniciar";
            this.Iniciarbutton.UseVisualStyleBackColor = true;
            this.Iniciarbutton.Click += new System.EventHandler(this.Iniciarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.Iniciarbutton);
            this.Controls.Add(this.TiempotextBox);
            this.Controls.Add(this.TempApagadotextBox);
            this.Controls.Add(this.TempEncendidotextBox);
            this.Controls.Add(this.SuspencioncheckBox);
            this.Controls.Add(this.ApagadocheckBox);
            this.Controls.Add(this.EncendidocheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EnfriamientotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PuertaVentanacheckBox);
            this.Controls.Add(this.PuertacheckBox);
            this.Controls.Add(this.VentanacheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox VentanacheckBox;
        private System.Windows.Forms.CheckBox PuertacheckBox;
        private System.Windows.Forms.CheckBox PuertaVentanacheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EnfriamientotextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ApagadocheckBox;
        private System.Windows.Forms.CheckBox EncendidocheckBox;
        private System.Windows.Forms.CheckBox SuspencioncheckBox;
        private System.Windows.Forms.TextBox TempEncendidotextBox;
        private System.Windows.Forms.TextBox TempApagadotextBox;
        private System.Windows.Forms.TextBox TiempotextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Iniciarbutton;
    }
}

