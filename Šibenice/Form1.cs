using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Šibenice
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
            ZacatekHry();
        }

        private int errors = 0;
        private void ZacatekHry()
        {
            errors = 0;
           LoadPicture(errors);
    
        }
        private string GetAppDir
        {
            get 
            {
                FileInfo fi = new FileInfo(Application.ExecutablePath);
                return fi.DirectoryName;
            }

        }
        
        private bool LoadPicture(int i)
        {
            string dir = GetAppDir + @"\obrazky\";
            string jmeno = dir + i.ToString().PadLeft(2, '0') + ".bmp";
            if (File.Exists(jmeno))
            {
                pictureBox1.Image = new Bitmap(jmeno);
                return true;
            }
             return false;
        }

        private void KonecHry()
        {
            MessageBox.Show("Prohrál(a) jsi!");
        }

        private void Chyba()
        {
            
            bool ok = LoadPicture (errors);
            if (!ok)
                KonecHry();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ZacatekHry();
            //odkrejt vsechny cudliky
            label1.Text = Nitro.generuj();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();
            button18.Show();
            button19.Show();
            button20.Show();
            button21.Show();
            button22.Show();
            button23.Show();
            button24.Show();
            button25.Show();
            button26.Show();
            button27.Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char pismeno='A';
            label1.Text = Nitro.test(pismeno);            
            button2.Hide();
            errors = Nitro.errory;
            Chyba();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            char pismeno = 'B';
            label1.Text = Nitro.test(pismeno);            
            button6.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char pismeno = 'C';
            label1.Text = Nitro.test(pismeno);
            button5.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char pismeno = 'D';
            label1.Text = Nitro.test(pismeno);
            button4.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char pismeno = 'E';
            label1.Text = Nitro.test(pismeno);
            button3.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            char pismeno = 'F';
            label1.Text = Nitro.test(pismeno);            
            button26.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            char pismeno = 'G';
            label1.Text = Nitro.test(pismeno);
            button25.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char pismeno = 'H';
            label1.Text = Nitro.test(pismeno);
            button8.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            char pismeno = 'I';
            label1.Text = Nitro.test(pismeno);
            button24.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            char pismeno = 'J';
            label1.Text = Nitro.test(pismeno);
            button23.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            char pismeno = 'K';
            label1.Text = Nitro.test(pismeno);
            button22.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            char pismeno = 'L';
            label1.Text = Nitro.test(pismeno);
            button21.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            char pismeno = 'M';
            label1.Text = Nitro.test(pismeno);
            button20.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            char pismeno = 'N';
            label1.Text = Nitro.test(pismeno);
            button19.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            char pismeno = 'O';
            label1.Text = Nitro.test(pismeno);
            button18.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            char pismeno = 'P';
            label1.Text = Nitro.test(pismeno);
            button17.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            char pismeno = 'Q';
            label1.Text = Nitro.test(pismeno);
            button16.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            char pismeno = 'R';
            label1.Text = Nitro.test(pismeno);
            button15.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            char pismeno = 'S';
            label1.Text = Nitro.test(pismeno);
            button14.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            char pismeno = 'T';
            label1.Text = Nitro.test(pismeno);
            button13.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            char pismeno = 'U';
            label1.Text = Nitro.test(pismeno);
            button12.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            char pismeno = 'V';
            label1.Text = Nitro.test(pismeno);
            button11.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char pismeno = 'W';
            label1.Text = Nitro.test(pismeno);
            button10.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char pismeno = 'Z';
            label1.Text = Nitro.test(pismeno);
            button9.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            char pismeno = 'X';
            label1.Text = Nitro.test(pismeno);
            button7.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            char pismeno = 'Y';
            label1.Text = Nitro.test(pismeno);
            button27.Hide();
            errors = Nitro.errory;
            Chyba();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
