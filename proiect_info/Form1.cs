using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proiect_info
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundplayer;
        private SoundPlayer _soundplayer2;
        public Form1()
        {
            InitializeComponent();
         
            _soundplayer2 = new SoundPlayer("1441_Click2.wav");
        }

        private void hek_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void start(object sender, EventArgs e)
        {
            
            _soundplayer2.Play();
            this.Hide();//
            Fila2 fila2 = new Fila2();
            fila2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            _soundplayer2.Play();
            this.Hide();
            Fila2 fila2 = new Fila2();
            fila2.Show();
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
