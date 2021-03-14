using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGo1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(textBox2.Text, textBox3.Text);
        }

        private void buttonGo2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(textBox4.Text, "");
        }

        private void buttonGo3_Click(object sender, EventArgs e)
        {
            int position = Int32.Parse(textBox5.Text);
                try
                {
                  textBox6.Text = "";
                  textBox6.Text = textBox6.Text + textBox1.Text[position];
                }
                catch (IndexOutOfRangeException ex)
                {
                  MessageBox.Show("Неверный индекс!");
                  return;
                }
        }

        private void buttonGo4_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox7.Text = textBox7.Text + textBox1.Text.Length;
        }

        private void buttonGo5_Click(object sender, EventArgs e)
        {
            int vowels = 0, consonants = 0, sentences = 0, words = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if((textBox1.Text[i]>='a' && textBox1.Text[i] <='z')|| (textBox1.Text[i] >= 'A' && textBox1.Text[i] <= 'Z'))
                {
                    if (textBox1.Text[i] == 'a' || textBox1.Text[i] == 'e' ||
                        textBox1.Text[i] == 'y' || textBox1.Text[i] == 'u' ||
                        textBox1.Text[i] == 'i' || textBox1.Text[i] == 'o' ||
                        textBox1.Text[i] == 'A' || textBox1.Text[i] == 'E' ||
                        textBox1.Text[i] == 'Y' || textBox1.Text[i] == 'U' ||
                        textBox1.Text[i] == 'I' || textBox1.Text[i] == 'O')
                        vowels++;
                    else 
                        consonants++;
                }
            }

            textBox8.Text = "";
            textBox8.Text = Convert.ToString(vowels);

            textBox9.Text = "";
            textBox9.Text = Convert.ToString(consonants);

            ////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                
                if (i > 0)
                {
                    if ((textBox1.Text[i] == '.' || textBox1.Text[i] == '!' ||
                      textBox1.Text[i] == '?') && ((textBox1.Text[i] >= 'a' && textBox1.Text[i] <= 'z')
                      || (textBox1.Text[i - 1] >= 'A' && textBox1.Text[i - 1] <= 'Z')))
                        sentences++;

                    if (i > 1)
                    {
                        if (vowels > 0 || consonants > 0)
                        {
                            if (textBox1.Text[i] == '.' && textBox1.Text[i - 1] == ' ' && 
                                ((textBox1.Text[i] >= 'a' && textBox1.Text[i] <= 'z') ||
                                (textBox1.Text[i - 1] >= 'A' && textBox1.Text[i - 1] <= 'Z')))
                                sentences++;
                        }
                    } 
                }

                if (textBox1.Text[i] == '.' || textBox1.Text[i] == '!' ||
                    textBox1.Text[i] == '?')
                    if (i + 1 != textBox1.Text.Length) 
                        if (textBox1.Text[i+1] == ' ')
                            sentences++;


                if (i + 1 != textBox1.Text.Length)
                {
                    if (((textBox1.Text[i] >= 'a' && textBox1.Text[i] <= 'z') || (textBox1.Text[i] >= 'A' && textBox1.Text[i] <= 'Z')) &&
                        (textBox1.Text[i + 1] == '.'|| textBox1.Text[i + 1] == '!' || textBox1.Text[i + 1] == '?' 
                        || textBox1.Text[i + 1] == ',' || textBox1.Text[i + 1] == ' '))
                        words++;
                }

                if (i + 1 == textBox1.Text.Length)
                {
                    if ((textBox1.Text[i] >= 'a' && textBox1.Text[i] <= 'z') ||
                        (textBox1.Text[i] >= 'A' && textBox1.Text[i] <= 'Z'))
                        words++;
                }
                
            }

            textBox10.Text = "";
            textBox10.Text = Convert.ToString(sentences);

            textBox11.Text = "";
            textBox11.Text = Convert.ToString(words);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private bool Checker(object sender, EventArgs e)
        {
            bool right = true;

            

            return right;
        }

    }
}
