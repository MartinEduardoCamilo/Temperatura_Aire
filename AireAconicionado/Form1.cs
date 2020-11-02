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
            numero = random.Next(1, 3);
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

                    } break;
                case 2:
                    {
                        PuertacheckBox.Checked = true;
                        VentanacheckBox.Checked = false;
                        PuertaVentanacheckBox.Checked = false;
                        
                    }break;
                case 3:
                    {
                        PuertaVentanacheckBox.Checked = true;
                        PuertacheckBox.Checked = false;
                        VentanacheckBox.Checked = false;
                        
                    }break;

                default: break;
            }
        }


        private void GraficoBarra(int numero)
        {
            switch (numero)
            {
                case 1:
                    {
                        
                    }
                    break;
                case 2:
                    {
                       

                    }
                    break;
                case 3:
                    {
                        

                    }
                    break;

                default: break;
            }
        }

      
    }
}
