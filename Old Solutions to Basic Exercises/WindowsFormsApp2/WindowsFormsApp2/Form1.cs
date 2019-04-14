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
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        String word;
        List<string> words;
        int count;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Countries");
            comboBox1.Items.Add("Cities");
            pictureBox1.Image = Properties.Resources.seven;
            word = "";
            words = new List<string>();
            count = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String substring = textBox1.Text;
            bool statement = false;
            int index = word.IndexOf(substring);
            StringBuilder str = new StringBuilder(label1.Text);
            while(index != -1)
            {
                statement = true;
                str.Remove(index, substring.Length);
                str.Insert(index, substring);
                if (!str.ToString().Contains("-"))
                {
                    label1.Text = word;
                    MessageBox.Show("YOu win!!");
                    Form1 f1 = new Form1();
                    f1.Show();
                    break;
                }
                index = word.IndexOf(substring, index + 1);
            }
            if (!statement)
            {
                count--;
                switch (count)
                {
                    case 6:
                        pictureBox1.Image = Properties.Resources.six;
                        break;

                    case 5:
                        pictureBox1.Image = Properties.Resources.five;
                        break;

                    case 4:
                        pictureBox1.Image = Properties.Resources.four;
                        break;

                    case 3:
                        pictureBox1.Image = Properties.Resources.three;
                        break;

                    case 2:
                        pictureBox1.Image = Properties.Resources.two;
                        break;

                    case 1:
                        pictureBox1.Image = Properties.Resources.one;
                        break;

                    default:
                        pictureBox1.Image = Properties.Resources.zero;
                        MessageBox.Show($"You lose! The word was {word}");
                        Form1 f1 = new Form1();
                        f1.Show();
                        break;

                }

            }
            label1.Text = str.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            StreamReader reader;
            int index = comboBox1.SelectedIndex;
            String line;
            if(index == 0)
            {
                reader = new StreamReader(@"C:\Users\ivani\Desktop\countries.txt");
            }
            else
            {
                reader = new StreamReader(@"C:\Users\ivani\Desktop\cities.txt");

            }
            while((line = reader.ReadLine()) != null)
            {
                words.Add(line);
            }
            word = words[random.Next(0, words.Count)];
            label1.Text = Regex.Replace(word, "[A-Za-z]", "-");
        }
    }
}
