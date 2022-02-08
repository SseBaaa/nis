using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcija_List
{
    public partial class Form1 : Form
    {

        List<Ucenik> ucenici = new List<Ucenik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            try
            {
                Ucenik ucenik = new Ucenik(textBoxIme.Text, textBoxPrezime.Text, comboBoxRazred.Text);
                ucenici.Add(ucenik);
                textBoxIme.Clear();
                textBoxPrezime.Clear();
                MessageBox.Show("Uspješan unos!" ,"Obabijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos! \r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonPregled_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ime" + "\tPrezime" + "\tRazred\r\n";
        foreach(Ucenik ucenik in ucenici)
            {
                richTextBox1.AppendText(ucenik.ToString() + "\r\n");
            }   
        }

        private void buttonObrada_Click(object sender, EventArgs e)
        {
            foreach(Ucenik ucenik in ucenici)
            {
                if(ucenik.Razred == "2.")
                {
                    ucenik.Razred = "3.";
                }
            }
            richTextBox1.AppendText("__________Obrada__________" + "\r\n");
            foreach (Ucenik ucenik in ucenici)
            {
                richTextBox1.AppendText(ucenik.ToString() + "\r\n");
            }
        }
    }
}
