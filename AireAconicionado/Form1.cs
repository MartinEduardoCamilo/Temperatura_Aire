﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace AireAconicionado
{
    public partial class Form1 : Form
    {

        private int Acumulador_Temp { get; set; }
        private double Acumulador { get; set; }
        public Form1()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Temperatura de encendido del aire";
            c1.Width = 130;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Temperatura de apagdo del aire";
            c2.Width = 100;
            c2.ReadOnly = true;

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Tiempo";
            c3.Width = 90;
            c3.ReadOnly = true;

            dataGridView1.Columns.Add(c1);
            dataGridView1.Columns.Add(c2);
            dataGridView1.Columns.Add(c3);

            IniciarcheckBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Generarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int TempAmbiente = (int)TempEncendidonumericUpDown.Value;
            int TempAire = (int)TempApagadonumericUpDown.Value;
            double Tiempo = (int)TiemponumericUpDown.Value;



            if (TiemponumericUpDown.Value > 15)
            {
                errorProvider1.SetError(TiemponumericUpDown, "El tiempo debe ser menor 15.. ");
                TiemponumericUpDown.Focus();
            }
            else if (TiemponumericUpDown.Value <= 0)
            {
                errorProvider1.SetError(TiemponumericUpDown, "El tiempo debe ser mayor que !Cero!");
                TiemponumericUpDown.Focus();
            }

            if (TempEncendidonumericUpDown.Value <= 17)
            {
                errorProvider1.SetError(TempEncendidonumericUpDown, "Esta temperatura no puede ser menor o igual de 17 grados!!!!");
                TempEncendidonumericUpDown.Focus();
            }
            else if (TempEncendidonumericUpDown.Value <= 25)
            {
                errorProvider1.SetError(TempEncendidonumericUpDown, "La temperatura aun esta agradable Todavia debe ser mayor a 25.. ");
                TempEncendidonumericUpDown.Focus();
            }

            if (TempApagadonumericUpDown.Value <= 16)
            {
                errorProvider1.SetError(TempApagadonumericUpDown, "Esta temperatura debe ser mayor a 16 Grados..");
                TempApagadonumericUpDown.Focus();
            }
            else if (TempApagadonumericUpDown.Value > 21)
            {
                errorProvider1.SetError(TempApagadonumericUpDown, "Esta temperatura pasa los 21 grados..");
                TempApagadonumericUpDown.Focus();
            }


            if (TempApagadonumericUpDown.Value == 0 && TempEncendidonumericUpDown.Value == 0 && TiemponumericUpDown.Value == 0 || TempEncendidonumericUpDown.Value == TempApagadonumericUpDown.Value)
            {
                errorProvider1.SetError(Generarbutton, "Los campos estan vacios");
                Generarbutton.Focus();
                IniciarcheckBox.Enabled = false;
            }
            else if(TempEncendidonumericUpDown.Value >=20 || TempApagadonumericUpDown.Value < TempEncendidonumericUpDown.Value)
            {
                Calcular(TempAmbiente, TempAire, Tiempo);
                IniciarcheckBox.Enabled = true;
            }
                               
        }

        private void Calcular(int TempAmbiente, int TempAire, double Tiempo)
        {

            const double ventana = 0.10;
            const double Puerta = 0.25;

            double Enfriamiento = 0;

            

            if (VentanacheckBox.Checked == true)
            {
                Enfriamiento = Tiempo - (Tiempo * ventana);
                Tiempo += Enfriamiento;

                convertir(Enfriamiento);

                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (Acumulador_Temp < TempAmbiente && Acumulador_Temp > 0)
                {
                   TempAmbiente = Acumulador_Temp;
                   Enfriamiento = Acumulador;
                }

                Acumulador_Temp = TempAmbiente-1;
                Acumulador = Enfriamiento -1;
                dataGridView1.Rows.Add(Acumulador_Temp, TempAire, Acumulador);

                if (Acumulador_Temp == TempAire)
                {
                    Times.Stop();
                    Desactivar();
                }

            }
            else if (PuertacheckBox.Checked == true)
            {
                Enfriamiento = Tiempo - (Tiempo * Puerta);
                Tiempo += Enfriamiento;

                convertir(Enfriamiento);

                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (Acumulador_Temp < TempAmbiente && Acumulador_Temp > 0)
                {
                    TempAmbiente = Acumulador_Temp;
                    Enfriamiento = Acumulador;
                }

                Acumulador_Temp = TempAmbiente - 1;
                Acumulador = Enfriamiento - 1;
                dataGridView1.Rows.Add(Acumulador_Temp, TempAire, Acumulador);

                if (Acumulador_Temp == TempAire)
                {
                    Times.Stop();
                    Desactivar();
                }
            }
            else if (PuertaVentanacheckBox.Checked == true)
            {
                Enfriamiento = Tiempo - (Tiempo * (ventana + Puerta));
                Tiempo += Enfriamiento;

                convertir(Enfriamiento);

                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (Acumulador_Temp < TempAmbiente && Acumulador_Temp > 0)
                {
                    TempAmbiente = Acumulador_Temp;
                    Enfriamiento = Acumulador;
                }

                Acumulador_Temp = TempAmbiente - 1;
                Acumulador = Enfriamiento - 1;

                dataGridView1.Rows.Add(Acumulador_Temp, TempAire, Acumulador);

                if (Acumulador_Temp == TempAire)
                {
                    Times.Stop();
                    Desactivar();
                }
            }
            else
            {
                Enfriamiento = Tiempo;
                Tiempo += Enfriamiento;

                convertir(Enfriamiento);

                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (Acumulador_Temp < TempAmbiente && Acumulador_Temp > 0)
                {
                    TempAmbiente = Acumulador_Temp;
                    Enfriamiento = Acumulador;
                }

                Acumulador_Temp = TempAmbiente - 1;
                Acumulador = Enfriamiento - 1;
                dataGridView1.Rows.Add(Acumulador_Temp, TempAire, Acumulador);

                if (Acumulador_Temp == TempAire)
                {
                    Times.Stop();
                    Desactivar();
                }
            }

        } 
        
        private void VentanacheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            PuertacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
            dataGridView1.Rows.Clear();
            Acumulador_Temp = 0;
            TempEncendidonumericUpDown.ReadOnly = false;
            TempEncendidonumericUpDown.Increment = 1;
        }

        private void PuertacheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            VentanacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
            dataGridView1.Rows.Clear();
            Acumulador_Temp = 0;
            TempEncendidonumericUpDown.ReadOnly = false;
            TempEncendidonumericUpDown.Increment = 1;
        }

        private void PuertaVentanacheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            VentanacheckBox.Checked = false;
            PuertacheckBox.Checked = false;
            dataGridView1.Rows.Clear();
            Acumulador_Temp = 0;
            TempEncendidonumericUpDown.ReadOnly = false;
            TempEncendidonumericUpDown.Increment = 1;
        }

        private void IniciarcheckBox_MouseClick(object sender, MouseEventArgs e)
        {

            if (IniciarcheckBox.Checked == true)
            {
                Times.Start();
                EncendidocheckBox.Checked = true;
                ApagadocheckBox.Checked = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TempAmbiente = (int)TempEncendidonumericUpDown.Value;
            int TempAire = (int)TempApagadonumericUpDown.Value;
            double Tiempo = (int)TiemponumericUpDown.Value;

            Calcular(TempAmbiente, TempAire, Tiempo);
        }
        
        private void Limpiarbutton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();          
            dataGridView1.Rows.Clear();
            TiemponumericUpDown.Value = 0;
            TempEncendidonumericUpDown.Value = 0;
            TempApagadonumericUpDown.Value = 0;
            EnfriamientotextBox.Text = String.Empty;
            VentanacheckBox.Checked = false;
            PuertacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
            IniciarcheckBox.Checked = false;
            TempApagadonumericUpDown.ReadOnly = false;
        }

        private void Desactivar()
        {
            
            TempEncendidonumericUpDown.ReadOnly = true;
            TempEncendidonumericUpDown.Value = Acumulador_Temp;
            TempEncendidonumericUpDown.Increment = 0;
            ApagadocheckBox.Checked = true;
            EncendidocheckBox.Checked = false;
            IniciarcheckBox.Checked = false;
            VentanacheckBox.Checked = false;
            PuertacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
            EnfriamientotextBox.Text = String.Empty;
        }


        private void convertir(double Tiempo)
        {
            int resultado = (int)((Convert.ToInt64(Tiempo)) * 1000);

            Times.Interval = resultado;
        }

    }
}
