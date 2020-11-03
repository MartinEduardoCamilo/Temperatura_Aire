using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace AireAconicionado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Iniciarbutton_Click(object sender, EventArgs e)
        {

            if (VentanacheckBox.Checked == true)
            {
                PuertaVentanacheckBox.Checked = false;
                PuertacheckBox.Checked = false;
                GraficoBarra();
            }
            else if (PuertacheckBox.Checked == true)
            {
                PuertaVentanacheckBox.Checked = false;
                VentanacheckBox.Checked = false;
                GraficoBarra();
            }
            else if (PuertaVentanacheckBox.Checked == true)
            {
                PuertacheckBox.Checked = false;
                VentanacheckBox.Checked = false;
                GraficoBarra();
            }
            else
            {
                PuertaVentanacheckBox.Checked = false;
                PuertacheckBox.Checked = false;
                VentanacheckBox.Checked = false;
                GraficoBarra();
            }
        }


        private void GraficoBarra()
        {
            const double ventana = 0.10;
            const double Puerta = 0.25;

            int TempAmbiente = (int)TempAmbientenumericUpDown.Value;
            int TempAire = (int)TempAierenumericUpDown.Value;
            double Tiempo = (int)TiemponumericUpDown.Value;

            double aux = 0;
            double Enfriamiento = 0;
           
            if (VentanacheckBox.Checked == true)
            {
                aux = (TempAmbiente - TempAire) * ventana; // cuando una ventana esta abierta se aumenta la temperatura de la habitacion
                Enfriamiento = Tiempo * ventana;
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                double[] Datos1 = { TempAmbiente, TempAire, Enfriamiento };
                GenerarGrafico(Datos1);
            }
            else if (PuertacheckBox.Checked == true)
            {
                aux = (TempAmbiente - TempAire) * Puerta; // cuando la puerta esta abierta se aumenta la temperatura de la habitacion
                Enfriamiento = Tiempo * Puerta;
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                double[] Datos1 = { TempAmbiente, TempAire, Enfriamiento };
                GenerarGrafico(Datos1);
            }
            else if (PuertaVentanacheckBox.Checked == true)
            {
                aux = (TempAmbiente - TempAire) * (ventana + Puerta); //cuando una ventana y la puerta esta abierta se aumenta la temperatura de la habitacion
                Enfriamiento = Tiempo * (ventana + Puerta);
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                double[] Datos1 = { TempAmbiente, TempAire, Enfriamiento };
                GenerarGrafico(Datos1);
            }
            else
            {
                aux = (TempAmbiente - TempAire); // Temperatura de la habitacion se reduce cuando la puerta y ventana esta cerrada
                Enfriamiento = Tiempo;
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                double[] Datos1 = { TempAmbiente, TempAire, Enfriamiento };
                GenerarGrafico(Datos1);
            }

        } 
        
        private void GenerarGrafico(double[] numero)
        {
            string[] serie = { "Temperatura Ambiente", "Temperatura del Aire", "Tiempo de encendido del aire" };


            for (int i = 0; i <serie.Length; i++)
            {
                Series series = Graficachart.Series.Add(serie[i]);
                series.Label = numero[i].ToString();

                series.Points.Add(numero[i]);
            }
        }
    }
}
