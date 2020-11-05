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

        public int aux { get; set; }

        public Form1()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Temperatura Ambiente";
            c1.Width = 130;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Temperatura del aire";
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

            int TempAmbiente = (int)TempAmbientenumericUpDown.Value;
            int TempAire = (int)TempAierenumericUpDown.Value;
            double Tiempo = (int)TiemponumericUpDown.Value;


            Calcular(TempAmbiente, TempAire, Tiempo);

            IniciarcheckBox.Enabled = true;            
            
        }

        private void Calcular(int TempAmbiente, int TempAire, double Tiempo)
        {
            IniciarcheckBox.Checked = true;

            const double ventana = 0.10;
            const double Puerta = 0.25;

            double Enfriamiento = 0;

            if (TiemponumericUpDown.Value  > 15  )
            {
                errorProvider1.SetError(TiemponumericUpDown, "El tiempo debe ser menor 15.. ");
                TiemponumericUpDown.Focus();
            }
            else if(TiemponumericUpDown.Value <= 0)
            {
                errorProvider1.SetError(TiemponumericUpDown, "El tiempo debe ser mayor que !Cero!");
                TiemponumericUpDown.Focus();
            }

            if (TempAmbientenumericUpDown.Value <= 17)
            {
                errorProvider1.SetError(TempAmbientenumericUpDown, "Esta temperatura no puede ser menor de 25 grados!!!!");
                TempAmbientenumericUpDown.Focus();
            }
            else if (TempAmbientenumericUpDown.Value < 25)
            {
                errorProvider1.SetError(TempAmbientenumericUpDown, "La temperatura aun esta agradable Todavia debe ser mayor a 25.. ");
                TempAmbientenumericUpDown.Focus();
            }

            if (TempAierenumericUpDown.Value <= 16)
            {
                errorProvider1.SetError(TempAierenumericUpDown, "Esta temperatura debe ser mayor a 16 Grados..");
                TempAierenumericUpDown.Focus();
            }
            else if (TempAierenumericUpDown.Value > 21)
            {
                errorProvider1.SetError(TempAierenumericUpDown, "Esta temperatura pasa los 21 grados..");
                TempAierenumericUpDown.Focus();
            }

            if (VentanacheckBox.Checked == true)
            {
               
                Enfriamiento = Tiempo - (Tiempo * ventana);
                convertir(Enfriamiento);
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                dataGridView1.Rows.Add(TempAmbiente,TempAire,Enfriamiento);
                dataGridView1.Rows.Clear();

            }
            else if (PuertacheckBox.Checked == true)
            {
                
                Enfriamiento = Tiempo- (Tiempo * Puerta);
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                dataGridView1.Rows.Add(TempAmbiente, TempAire, Enfriamiento);
                dataGridView1.Rows.Clear();
            }
            else if (PuertaVentanacheckBox.Checked == true)
            {
                
                Enfriamiento =  Tiempo - (Tiempo * (ventana + Puerta));
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                dataGridView1.Rows.Add(TempAmbiente, TempAire, Enfriamiento);
                dataGridView1.Rows.Clear();
            }
            else
            {
                
                Enfriamiento = Tiempo;
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                dataGridView1.Rows.Add(TempAmbiente, TempAire, Enfriamiento);
                dataGridView1.Rows.Clear();
            }          
        } 
        
        private void VentanacheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            PuertacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
            dataGridView1.Rows.Clear();
            aux = 0;
            TempAmbientenumericUpDown.ReadOnly = false;
            TempAmbientenumericUpDown.Increment = 1;
        }

        private void PuertacheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            VentanacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
            dataGridView1.Rows.Clear();
            aux = 0;
            TempAmbientenumericUpDown.ReadOnly = false;
            TempAmbientenumericUpDown.Increment = 1;
        }

        private void PuertaVentanacheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            VentanacheckBox.Checked = false;
            PuertacheckBox.Checked = false;
            dataGridView1.Rows.Clear();
            aux = 0;
            TempAmbientenumericUpDown.ReadOnly = false;
            TempAmbientenumericUpDown.Increment = 1;
        }

        private void IniciarcheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            
            timer1.Start();
            EncendidocheckBox.Checked = true;
            ApagadocheckBox.Checked = false;     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TempAmbiente = (int)TempAmbientenumericUpDown.Value;
            int TempAire = (int)TempAierenumericUpDown.Value;
            double Tiempo = (int)TiemponumericUpDown.Value;

            const double ventana = 0.10;
            const double Puerta = 0.25;
            double Enfriamiento = 0;


            if (VentanacheckBox.Checked == true)
            {
                Enfriamiento = Tiempo - (Tiempo * ventana);
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();

                if (aux < TempAmbiente && aux > 0)
                {
                    TempAmbiente = aux;
                }
                aux = TempAmbiente - 1;

                dataGridView1.Rows.Add(aux, TempAire, Enfriamiento);

                if (aux == TempAire)
                {
                    timer1.Stop();
                    Desactivar();                   
                }

            }
            else if (PuertacheckBox.Checked == true)
            {
                Enfriamiento =   Tiempo - (Tiempo * Puerta);
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                if (aux < TempAmbiente && aux > 0)
                {
                    TempAmbiente = aux;
                }
                aux = TempAmbiente - 1;
                dataGridView1.Rows.Add(aux, TempAire, Enfriamiento);
                if (aux == TempAire)
                {
                    timer1.Stop();
                    Desactivar();
                }
            }
            else if (PuertaVentanacheckBox.Checked == true)
            {
                Enfriamiento =  Tiempo- (Tiempo * (ventana + Puerta));
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                if (aux < TempAmbiente && aux > 0)
                {
                    TempAmbiente = aux;
                }
                aux = TempAmbiente - 1;
                dataGridView1.Rows.Add(aux, TempAire, Enfriamiento);
                if (aux == TempAire)
                {
                    timer1.Stop();
                    Desactivar();
                }
            }
            else
            {
                Enfriamiento = Tiempo;
                Tiempo += Enfriamiento;
                EnfriamientotextBox.Text = Enfriamiento.ToString();
                if (aux < TempAmbiente && aux > 0)
                {
                    TempAmbiente = aux;
                }
                aux = TempAmbiente - 1;
                dataGridView1.Rows.Add(aux, TempAire, Enfriamiento);
                if (aux == TempAire)
                {
                    timer1.Stop();
                    Desactivar();

                }
            }
        }
        
        private void Limpiarbutton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();          
            dataGridView1.Rows.Clear();
            TiemponumericUpDown.Value = 0;
            TempAmbientenumericUpDown.Value = 0;
            TempAierenumericUpDown.Value = 0;
            EnfriamientotextBox.Text = String.Empty;
            VentanacheckBox.Checked = false;
            PuertacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
            IniciarcheckBox.Checked = false;
        }

        private void Desactivar()
        {
            
            TempAmbientenumericUpDown.ReadOnly = true;
            TempAmbientenumericUpDown.Value = aux;
            TempAmbientenumericUpDown.Increment = 0;
            ApagadocheckBox.Checked = true;
            EncendidocheckBox.Checked = false;
            IniciarcheckBox.Checked = false;
            VentanacheckBox.Checked = false;
            PuertacheckBox.Checked = false;
            PuertaVentanacheckBox.Checked = false;
        }


        private void convertir(double Tiempo)
        {
            int n = ((int)Tiempo) * 1000000;

            timer1.Interval = n;
        }

    }
}
