using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_Game
{
    public partial class Form1 : Form
    {
        int contadorMovimientos = 1;
        bool volarArriba = false;
        int distancia = 0;
        Random posicionRdm = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {
            pictureBox_Doge.Location = new Point(19, 255);
            distancia = posicionRdm.Next(-160, 118);
            pictureBox_TuboArriba.Location = new Point(270, -173 - distancia);
            pictureBox_TuboAbajo.Location = new Point(270, 319 - distancia);
            label_Puntuacion.Text = "0";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cantidadMovimientos = 5;
            if (contadorMovimientos <= cantidadMovimientos)
            {
                pictureBox_Doge.Image = Properties.Resources.doge_normal;
                    contadorMovimientos++;
            }
            if ((contadorMovimientos > cantidadMovimientos / 2) && (contadorMovimientos <= cantidadMovimientos * 2)){
                pictureBox_Doge.Image = Properties.Resources.doge_down;
                contadorMovimientos++;
            }

            contadorMovimientos = (contadorMovimientos > cantidadMovimientos * 2) ? 0 : contadorMovimientos;

            int lx = pictureBox_Doge.Location.X;
            int ly = pictureBox_Doge.Location.Y;

            if (volarArriba)
            {
                ly = ly - 15;
                volarArriba = false;
            }
            else
            {
                ly++;
            }

            pictureBox_Doge.Location = new Point(pictureBox_Doge.Location.X, ly);


            if ((pictureBox_Doge.Bounds.IntersectsWith(pictureBox_Barrera.Bounds)) || (pictureBox_Doge.Bounds.IntersectsWith(pictureBox_BarreraArriba.Bounds)) || (pictureBox_Doge.Bounds.IntersectsWith(pictureBox_TuboArriba.Bounds)) || (pictureBox_Doge.Bounds.IntersectsWith(pictureBox_TuboAbajo.Bounds)))
            {
                IniciarJuego();
            }

            label_Puntuacion.Text = (pictureBox_TuboArriba.Location.X == pictureBox_Doge.Location.X) ? Convert.ToString((Convert.ToInt32(label_Puntuacion.Text) + 1)).ToString() : label_Puntuacion.Text;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox_TuboAbajo.Location.X > -140)
            {
                pictureBox_TuboAbajo.Location = new Point((pictureBox_TuboAbajo.Location.X) - 1, pictureBox_TuboAbajo.Location.Y);
                pictureBox_TuboArriba.Location = new Point((pictureBox_TuboArriba.Location.X) - 1, pictureBox_TuboArriba.Location.Y);
            }
            else
            {
                distancia = posicionRdm.Next(-170, 118);
                pictureBox_TuboAbajo.Location = new Point(400, 319 + distancia);
                pictureBox_TuboArriba.Location = new Point(400, -173 + distancia);

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space)){
                volarArriba = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox_Barrera.Location = (pictureBox_Barrera.Location.X > -480) ? new Point((pictureBox_Barrera.Location.X) - 1, pictureBox_Barrera.Location.Y) : pictureBox_Barrera.Location = new Point(-9, pictureBox_Barrera.Location.Y);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
