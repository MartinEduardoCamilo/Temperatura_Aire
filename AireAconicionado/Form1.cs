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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            Random Subida_temp = new Random();

            int subida = Subida_temp.Next(19, 30);

            Random Temp_aire = new Random();

            int bajada = Temp_aire.Next(17, 24);

            Random Tiempos = new Random();

            int Tiempo = Tiempos.Next(15, 20);


            Random Opciones = new Random();
            int opcion = Opciones.Next(1, 4);

            TempEncendidotextBox.Text = subida.ToString();
            TempApagadotextBox.Text = bajada.ToString();
            TiempotextBox.Text = Tiempo.ToString();


            Calcular(Tiempo, opcion);
        }


        private void VentanacheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            VentanacheckBox.Checked = true;
            PuertaVentanacheckBox.Checked = false;
            PuertacheckBox.Checked = false;
        }

        private void PuertacheckBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void PuertaVentanacheckBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Calcular(int Tiempo, int opcion)
        {

            double enfriamiento = 0;
            const double ventana = 0.10;
            const double puerta = 0.25;

            switch (opcion)
            {
                case 1:
                    {
                        VentanacheckBox.Checked = true;
                        PuertacheckBox.Checked = false;
                        PuertaVentanacheckBox.Checked = false;
                        enfriamiento = Tiempo + (Tiempo * ventana);
                        EnfriamientotextBox.Text = enfriamiento.ToString("N2");
                    }break;

                case 2:
                    {
                        VentanacheckBox.Checked = false;
                        PuertacheckBox.Checked = true;
                        PuertaVentanacheckBox.Checked = false;
                        enfriamiento = Tiempo + (Tiempo * puerta);
                        EnfriamientotextBox.Text = enfriamiento.ToString("N2");
                    }
                    break;
                case 3:
                    {
                        VentanacheckBox.Checked = false;
                        PuertacheckBox.Checked = false;
                        PuertaVentanacheckBox.Checked = true;
                        enfriamiento = Tiempo + (Tiempo * (ventana + puerta));
                        EnfriamientotextBox.Text = enfriamiento.ToString("N2");
                    }
                    break;

                case 4:
                    {
                        VentanacheckBox.Checked = false;
                        PuertacheckBox.Checked = false;
                        PuertaVentanacheckBox.Checked = false;
                        enfriamiento = Tiempo;
                        EnfriamientotextBox.Text = enfriamiento.ToString("N2");
                    }
                    break;
            }
        }

        
    }
}
