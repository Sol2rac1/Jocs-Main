using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI
{
    public partial class FrmPenjat : Form
    {
        //variables
        string Solucion;
        int resuelto = 0;
        string escrito;
        int intentos = 1;
        Random rnd = new Random();
        int r = 0;

        public event EventHandler emTanquen;
        public FrmPenjat()
        {
            InitializeComponent();
            seleccionarPlabra();
        }

        private void seleccionarPlabra()
        {
            r = rnd.Next(1, 11);
            switch (r)
            {
                case 1: Solucion = "abajo"; break;
                case 2: Solucion = "angel"; break;
                case 3: Solucion = "abajo"; break;
                case 4: Solucion = "aguja"; break;
                case 5: Solucion = "niños"; break;
                case 6: Solucion = "barco"; break;
                case 7: Solucion = "ebrio"; break;
                case 8: Solucion = "oasis"; break;
                case 9: Solucion = "vacio"; break;
                case 10: Solucion = "tapon"; break;
                case 11: Solucion = "jaume";break;
            }
        }

        private void FrmPenjat_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }

        private void FrmPenjat_Load(object sender, EventArgs e)
        {

        }

        private void estadoPalo()
        {
            //CONTADOR DE FALLOS Y CAMBIO DE IMAGEN
            intentos = intentos + 1;
            switch (intentos)
            {
                case 2: imgColgado.BackgroundImage = (Properties.Resources.Intento2); break;
                case 3: imgColgado.BackgroundImage = (Properties.Resources.Intento3); break;
                case 4: imgColgado.BackgroundImage = (Properties.Resources.Intento4); break;
                case 5: imgColgado.BackgroundImage = (Properties.Resources.Intento5); break;
                case 6: imgColgado.BackgroundImage = (Properties.Resources.Intento6); break;
                case 7: imgColgado.BackgroundImage = (Properties.Resources.Intento7); break;
                case 8: imgColgado.BackgroundImage = (Properties.Resources.Intento8); break;
                case 9: mostrarDerrota(); break;
            }
        }

        private void mostrarDerrota()
        {
            //muestra solucion y la respuesta
            MessageBox.Show("Que pena has perdido", "Perdedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            incog0.Text = Solucion[0].ToString();
            incog1.Text = Solucion[1].ToString();
            incog2.Text = Solucion[2].ToString();
            incog3.Text = Solucion[3].ToString();
            incog4.Text = Solucion[4].ToString();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            escrito = tb1.Text.ToString();
            if (escrito.Length == 1)
            {
                if (Solucion.Contains(escrito) == true)
                {
                    ponerLetra();
                }
                else estadoPalo();

            }
            else if (escrito == Solucion)
            {
                MessageBox.Show("Felicidades has ganado", "Ganador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                incog0.Text = Solucion[0].ToString();
                incog1.Text = Solucion[1].ToString();
                incog2.Text = Solucion[2].ToString();
                incog3.Text = Solucion[3].ToString();
                incog4.Text = Solucion[4].ToString();
            }
            else
            {
                estadoPalo();
            }
            tb1.Text = "";

        }

        private void ponerLetra()
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                if (escrito[0] == Solucion[i])
                {
                    switch (i)
                    {
                        case 0: incog0.Text = escrito; resuelto++; break;
                        case 1: incog1.Text = escrito; resuelto++; break;
                        case 2: incog2.Text = escrito; resuelto++; break;
                        case 3: incog3.Text = escrito; resuelto++; break;
                        case 4: incog4.Text = escrito; resuelto++; break;
                    }

                }
            }

            if (resuelto == 5)
            {
                MessageBox.Show("Felicidades has ganado", "Ganador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
