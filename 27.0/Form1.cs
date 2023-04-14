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
namespace _27._0
{
    public partial class Form1 : Form
    {
        public static string fileName;
        public Form1()
        {
            InitializeComponent();
            StreamWriter sw = new StreamWriter(fileName + "\\text.txt", true);
            fileName = Path.GetFullPath(".");
            fileName = Path.GetDirectoryName(fileName);
            Directory.CreateDirectory(fileName + "\\liste");
        } 
        public struct prod
        {
            public float prezzo;
            public string nome;
        }

        public prod prodotto;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                prodotto.nome = textBox1.Text;
                prodotto.prezzo = float.Parse(textBox2.Text);
                ScrittFile((prodotto.nome + ";" + prodotto.prezzo + ";").PadRight(20) + "##");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Select();
            }
        }
        public static void ScrittFile(string p)
        {
            var S= new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamWriter sw = new StreamWriter(S);
            sw.WriteLine(p);
            sw.Close();
        }









    }
} 
    