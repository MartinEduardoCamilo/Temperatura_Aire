using System;
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

        public int contador { get; set; }
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
            PararcheckBox.Enabled = false;
            IniciarcheckBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {                   
        }

        private void Generarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (TempEncendidonumericUpDown.Value >= 21 && TempEncendidonumericUpDown.Value <= 30)
            {
                
            }
            else
            {
                errorProvider1.SetError(TempEncendidonumericUpDown, "La Temperatura de Encendido debe estar 21 a 30 Grados.. ");
            }
            if (TempApagadonumericUpDown.Value >= 17 && TempApagadonumericUpDown.Value <= 20)
            {
                
            }
            else
            {
                errorProvider1.SetError(TempApagadonumericUpDown, "La Temperatura de Apagado debe de estar 17 a 20 Grados...");
            }

            if (TiemponumericUpDown.Value >= 15 && TiemponumericUpDown.Value <= 20)
            {
                
            }
            else
            {
                errorProvider1.SetError(TiemponumericUpDown, "El Tiempo debe de Estar entre 15 y 20 Minuto..");
            }

            PararcheckBox.Checked = false;
            PararcheckBox.Enabled = false;

           
                if (TempEncendidonumericUpDown.Value == 0 && TempApagadonumericUpDown.Value == 0 && EnfriamientotextBox.Text == string.Empty)
                {
                errorProvider1.Clear();
                    TimerAleatorio.Start();
                }
                else if(TempEncendidonumericUpDown.Value >= 21 && TempEncendidonumericUpDown.Value <= 30 && TempApagadonumericUpDown.Value >= 17 && TempApagadonumericUpDown.Value <= 20  && TiemponumericUpDown.Value >= 15 && TiemponumericUpDown.Value <= 20 )
                {
                errorProvider1.Clear();
                    int TempAmbiente = (int)TempEncendidonumericUpDown.Value;
                    int TempAire = (int)TempApagadonumericUpDown.Value;
                    double Tiempo = (int)TiemponumericUpDown.Value;

                    Calcular(TempAmbiente, TempAire, Tiempo);
                    IniciarcheckBox.Enabled = true;
                }
            

        }

        private void Calcular(int TempAmbiente, int TempAire, double Tiempo)
        {

            const double ventana = 0.10;
            const double Puerta = 0.25;

            double Enfriamiento = 0;

            PararcheckBox.Checked = false;
            PararcheckBox.Enabled = false;

            if (VentanacheckBox.Checked == true)
            {
                Enfriamiento = Tiempo - (Tiempo * ventana);
                Tiempo += Enfriamiento;
              
                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (Acumulador_Temp < TempAmbiente && Acumulador_Temp > 0)
                {
                   TempAmbiente = Acumulador_Temp;
                   Enfriamiento = Acumulador;
                }

                Acumulador_Temp = TempAmbiente-1;
                Acumulador = Enfriamiento - 0.69;

                convertir(Acumulador);

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

                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (Acumulador_Temp < TempAmbiente && Acumulador_Temp > 0)
                {
                    TempAmbiente = Acumulador_Temp;
                    Enfriamiento = Acumulador;
                }

                Acumulador_Temp = TempAmbiente - 1;
                Acumulador = Enfriamiento - 0.69;
                convertir(Acumulador);
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

                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (Acumulador_Temp < TempAmbiente && Acumulador_Temp > 0)
                {
                    TempAmbiente = Acumulador_Temp;
                    Enfriamiento = Acumulador;
                }

                Acumulador_Temp = TempAmbiente - 1;
                Acumulador = Enfriamiento - 0.69;

                convertir(Acumulador);

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

                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (Acumulador_Temp < TempAmbiente && Acumulador_Temp > 0)
                {
                    TempAmbiente = Acumulador_Temp;
                    Enfriamiento = Acumulador;
                }

                Acumulador_Temp = TempAmbiente - 1;
                Acumulador = Enfriamiento - 1;

                convertir(Acumulador);
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
            PararcheckBox.Checked = false;
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
            Limpiar();
        }

        private void Desactivar()
        {
            
            TempEncendidonumericUpDown.ReadOnly = true;
            TempEncendidonumericUpDown.Value = Acumulador_Temp;
            TempEncendidonumericUpDown.Increment = 0;
            ApagadocheckBox.Checked = true;
            EncendidocheckBox.Checked = false;

            if(ApagadocheckBox.Checked == true)
            {
                PararcheckBox.Enabled = true;
            }
            else
            {
                PararcheckBox.Checked = false;
            }

            IniciarcheckBox.Checked = false;
            VentanacheckBox.Checked = false;
            PuertacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
            EnfriamientotextBox.Text = String.Empty;
            if(TempEncendidonumericUpDown.ReadOnly == true)
            {
                TimerAuto.Start();
            }
            
        }


        private void convertir(double Tiempo)
        {
            int resultado = ((int)(Tiempo * 1000));

            Times.Interval = resultado;
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
          
            TimerAleatorio.Interval = 1000;

            contador++;

            if(contador == 5)
            {
                TimerAleatorio.Stop();
                contador = 0;
                Random Aleatorio = new Random();

                int subida = Aleatorio.Next(21, 30);
                int bajada = Aleatorio.Next(17, 20);
                double Tiempo = Aleatorio.Next(15, 20);
                int opcion = Aleatorio.Next(1, 4);


                switch (opcion)
                {
                    case 1:
                        {
                            VentanacheckBox.Checked = true;
                            PuertacheckBox.Checked = false;
                            PuertaVentanacheckBox.Checked = false;

                        }
                        break;

                    case 2:
                        {
                            VentanacheckBox.Checked = false;
                            PuertacheckBox.Checked = true;
                            PuertaVentanacheckBox.Checked = false;

                        }
                        break;
                    case 3:
                        {
                            VentanacheckBox.Checked = false;
                            PuertacheckBox.Checked = false;
                            PuertaVentanacheckBox.Checked = true;

                        }
                        break;

                    case 4:
                        {
                            VentanacheckBox.Checked = false;
                            PuertacheckBox.Checked = false;
                            PuertaVentanacheckBox.Checked = false;

                        }
                        break;
                }

                TempEncendidonumericUpDown.Value = subida;
                TempApagadonumericUpDown.Value = bajada;
                TiemponumericUpDown.Value = (int)Tiempo;

                Calcular(subida, bajada, Tiempo);

                IniciarcheckBox.Enabled = true;
                IniciarcheckBox.Checked = true;

                if (IniciarcheckBox.Checked == true)
                {
                    Times.Start();
                    EncendidocheckBox.Checked = true;
                    ApagadocheckBox.Checked = false;
                }
            }
        }

        private void TimerAuto_Tick(object sender, EventArgs e)
        {        

            TimerAuto.Interval = 1000;
            contador++;
            if (contador == 15)
            {
                TimerAuto.Stop();
                TempEncendidonumericUpDown.ReadOnly = false;
                contador = 0;
                Limpiar();
                Random Aleatorio = new Random();

                int subida = Aleatorio.Next(21, 30);
                int bajada = Aleatorio.Next(17, 20);
                double Tiempo = Aleatorio.Next(15, 20);
                int opcion = Aleatorio.Next(1, 4);


                switch (opcion)
                {
                    case 1:
                        {
                            VentanacheckBox.Checked = true;
                            PuertacheckBox.Checked = false;
                            PuertaVentanacheckBox.Checked = false;

                        }
                        break;

                    case 2:
                        {
                            VentanacheckBox.Checked = false;
                            PuertacheckBox.Checked = true;
                            PuertaVentanacheckBox.Checked = false;

                        }
                        break;
                    case 3:
                        {
                            VentanacheckBox.Checked = false;
                            PuertacheckBox.Checked = false;
                            PuertaVentanacheckBox.Checked = true;

                        }
                        break;

                    case 4:
                        {
                            VentanacheckBox.Checked = false;
                            PuertacheckBox.Checked = false;
                            PuertaVentanacheckBox.Checked = false;

                        }
                        break;
                }

                TempEncendidonumericUpDown.Value = subida;
                TempApagadonumericUpDown.Value = bajada;
                TiemponumericUpDown.Value = (int)Tiempo;

                Calcular(subida, bajada, Tiempo);

                IniciarcheckBox.Enabled = true;
                IniciarcheckBox.Checked = true;

                if (IniciarcheckBox.Checked == true)
                {
                    Times.Start();
                    EncendidocheckBox.Checked = true;
                    ApagadocheckBox.Checked = false;
                }
            }
        }

        private void Limpiar()
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
            Acumulador_Temp = 0;
            contador = 0;
        }

        private void PararcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TimerAleatorio.Stop();
            TimerAuto.Stop();
            Times.Stop();
            dataGridView1.Rows.Clear();
        }
    }
}
