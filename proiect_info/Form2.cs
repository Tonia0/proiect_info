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
    
    public partial class Fila2 : Form
    {
        int x = 0, x2=0, y=0;
        char n;
       public int puncte = 0;
        private SoundPlayer _soundplayer2;
        
        public Fila2()
        {
            InitializeComponent();
            _soundplayer2 = new SoundPlayer("1441_Click2.wav");
            
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "delfinul comun")
                puncte++;



        }

        private void var1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (x==1) var1.Checked = false;
            else
                {
                    var1.Checked = true;
                    x = 1;
                var2.Enabled = false;
                var3.Enabled = false;
            }
        }

        private void var2_CheckedChanged(object sender, EventArgs e)
        {
            if (x == 1) var2.Checked = false;
            else
            {
                var2.Checked = true;
                var3.Enabled = false;
                var1.Enabled = false;
                x = 1;
                puncte++;
            }
        }

        private void var3_CheckedChanged(object sender, EventArgs e)
        {
            if (x == 1) var3.Checked = false;
            else
            {
                var3.Checked = true;
                var2.Enabled = false;
                var1.Enabled = false;
                x = 1;
            }
        }

        private void te1_CheckedChanged(object sender, EventArgs e)
        {
            if (x2 == 1) te1.Checked = false;
            else
            {
                te1.Checked = true;
                te2.Enabled = false;
                te3.Enabled = false;
                x2 = 1;
                puncte++;
            }
        }

        private void te2_CheckedChanged(object sender, EventArgs e)
        {
            if (x2 == 1) te2.Checked = false;
            else
            {
                te2.Checked = true;
                te1.Enabled = false;
                te3.Enabled = false;
                x2 = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fila4 fila4 = new fila4();
           box2.Text =puncte.ToString();
            fila3 fila3 = new fila3();
            
            if (puncte == 4) 
                fila3.Show();
            

           else if (checkBox2.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (checkBox1.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (checkBox3.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (te2.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (te1.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (te3.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (var1.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (var2.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (var3.Checked = false) MessageBox.Show("nu ai completat toate câmpurile");
            else if (textBox1.TextLength==0) MessageBox.Show("nu ai completat toate câmpurile");
            else  fila4.Show();


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (y == 1) checkBox2.Checked = false;
            else
            {
                checkBox2.Checked = true;
                checkBox3.Enabled = false;
                checkBox1.Enabled = false;
                y = 1;
            }
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (y == 1) checkBox3.Checked = false;
            else
            {
                checkBox3.Checked = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                y = 1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            _soundplayer2.Play();
            this.Hide();
            ultima ultima = new ultima();
            ultima.Show();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _soundplayer2.Play();
            this.Hide();
            ultima ultima = new ultima();
            ultima.Show();

           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

      
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (y == 1) checkBox1.Checked = false;
            else
            {
                checkBox1.Checked = true;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                y = 1;
            }
            puncte++;
        }


        private void te3_CheckedChanged(object sender, EventArgs e)
        {
            if (y == 1) te3.Checked = false;
            else
            {
                te3.Checked = true;
                te2.Enabled = false;
                te1.Enabled = false;
                y = 1;
            }
        }


    }
}
