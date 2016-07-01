using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace crypto03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte[] alph;

        public void LCG(int length) // linear congruential generator
        {
            alph[0] = 24; byte A = 9, C = 49; int B = 256; // 
            richTextBox4.Text += "Гамма:\n" + Convert.ToString(alph[0]);
            for (int i = 1; i < length; i++)
            {
                alph[i] = (byte)((A * alph[i - 1] + C) % B);
                richTextBox4.Text += " " + Convert.ToString(alph[i]);
            }
            richTextBox4.Text += "\n\n";
        }
        
        private void copy_button_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(richTextBox2.Text); // copy to windows clipboard
        }

        private void more_options_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }

        private void encrypt_B_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = "";

            byte[] buffer = new byte[richTextBox1.Text.Length];
            Encoding win1251 = Encoding.GetEncoding(1251);
            buffer = win1251.GetBytes(richTextBox1.Text);

            for (int i = 0; i < buffer.Count(); i++)
                richTextBox4.Text += Convert.ToString(buffer[i]) + " ";
            richTextBox4.Text += "\n\n";

            richTextBox2.Text = "";
            richTextBox3.Text = richTextBox1.Text; //
            alph = new byte[buffer.Count()];
            LCG(buffer.Count());
            byte[] buffer2 = new byte[buffer.Count()];

            for (int i = 0; i < buffer.Count(); i++)
            {
                buffer2[i] = (byte)((alph[i] + buffer[i]) % 256);
            }

            for (int i = 0; i < buffer.Count(); i++)
                richTextBox4.Text += Convert.ToString(buffer2[i]) + " ";
            richTextBox4.Text += "\n\n";

            richTextBox2.Text = win1251.GetString(buffer2);
        }

        private void decrypt_B_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = "";

            byte[] buffer = new byte[richTextBox1.Text.Length];
            Encoding win1251 = Encoding.GetEncoding(1251);
            buffer = win1251.GetBytes(richTextBox1.Text);

            for (int i = 0; i < buffer.Count(); i++)
                richTextBox4.Text += Convert.ToString(buffer[i]) + " ";
            richTextBox4.Text += "\n\n";

            richTextBox2.Text = "";
            alph = new byte[buffer.Count()];
            LCG(buffer.Count());
            byte[] buffer2 = new byte[buffer.Count()];

            for (int i = 0; i < buffer.Count(); i++)
            {
                buffer2[i] = (byte)((buffer[i] + 256 - alph[i]) % 256);
            }

            for (int i = 0; i < buffer.Count(); i++)
                richTextBox4.Text += Convert.ToString(buffer2[i]) + " ";
            richTextBox4.Text += "\n\n";

            richTextBox2.Text = win1251.GetString(buffer2);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void swap_button_Click(object sender, EventArgs e)
        {
            String x1 = Convert.ToString(richTextBox1.Text);
            String x2 = Convert.ToString(richTextBox2.Text);

            richTextBox1.Text = x2;
            richTextBox2.Text = x1;
        }
    }
}
