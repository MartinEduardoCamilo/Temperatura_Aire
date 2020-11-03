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

        private int Decision()
        {
            int numero = 0;

            Random random = new Random();
            numero = random.Next(1, 4);
            return numero;
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            
            switch (Decision())
            {
                case 1:
                    {
                        VentanacheckBox.Checked = true;
                        PuertacheckBox.Checked = false;
                        PuertaVentanacheckBox.Checked = false;
                        GraficoBarra(Decision());
                    } break;
                case 2:
                    {
                        PuertacheckBox.Checked = true;
                        VentanacheckBox.Checked = false;
                        PuertaVentanacheckBox.Checked = false;
                        GraficoBarra(Decision());
                    }
                    break;
                case 3:
                    {
                        PuertaVentanacheckBox.Checked = true;
                        PuertacheckBox.Checked = false;
                        VentanacheckBox.Checked = false;
                        GraficoBarra(Decision());
                    }
                    break;
                case 4:
                    {
                        PuertaVentanacheckBox.Checked = false;
                        PuertacheckBox.Checked = false;
                        VentanacheckBox.Checked = false;
                        GraficoBarra(Decision());
                    }
                    break;

                default: break;
            }
        }


        private void GraficoBarra(int numero)
        {
            const double ventana = 0.10;
            const double Puerta = 0.25;

            int TempAmbiente = (int)TempAierenumericUpDown.Value;
            int TempAire = (int)TempAierenumericUpDown.Value;
            double Tiempo = (int)TiemponumericUpDown.Value;

            double aux = 0;
            double Enfriamiento = 0;


            switch (numero)
            {
                case 1:
                    {
                        aux = (TempAmbiente - TempAire) * ventana; // cuando una ventana esta abierta se aumenta la temperatura de la habitacion
                        Enfriamiento = Tiempo * ventana;
                        Tiempo += Enfriamiento;
                        EnfriamientotextBox.Text = Enfriamiento.ToString();
                    }
                    break;
                case 2:
                    {

                        aux = (TempAmbiente - TempAire) * Puerta; // cuando la puerta esta abierta se aumenta la temperatura de la habitacion
                        Enfriamiento = Tiempo * Puerta;
                        Tiempo += Enfriamiento;
                        EnfriamientotextBox.Text = Enfriamiento.ToString();
                    }
                    break;
                case 3:
                    {
                        aux = (TempAmbiente - TempAire) * (ventana + Puerta); //cuando una ventana y la puerta esta abierta se aumenta la temperatura de la habitacion
                        Enfriamiento = Tiempo * (ventana + Puerta);
                        Tiempo += Enfriamiento;
                        EnfriamientotextBox.Text = Enfriamiento.ToString();
                    }
                    break;
                case 4:
                    {

                        aux = (TempAmbiente - TempAire); // Temperatura de la habitacion se reduce cuando la puerta y ventana esta cerrada
                        Enfriamiento = Tiempo;
                        Tiempo += Enfriamiento;
                        EnfriamientotextBox.Text = Enfriamiento.ToString();
                    }
                    break;

                default: break;
            }
        }

      
    }
}
