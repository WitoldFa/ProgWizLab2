using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgWizLab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string WybranyProcesor { get; private set; }
        public string WybranyDysk { get; private set; }
        public int CenaKomputera { get; private set; }
        private void AktualizujCene()
        {
            int cenaCPU = 0;
            if (comboBox1.SelectedItem?.ToString() == "Intel i5") cenaCPU = 900;
            else if (comboBox1.SelectedItem?.ToString() == "Intel i7") cenaCPU = 1400;

            int cenaDysk = 0;
            if (radioButton1.Checked) cenaDysk = 200;
            else if (radioButton2.Checked) cenaDysk = 350;
            else if (radioButton3.Checked) cenaDysk = 500;

            textBox1.Text = cenaCPU.ToString();
            textBox2.Text = cenaDysk.ToString();
            textBox3.Text = (cenaCPU + cenaDysk).ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AktualizujCene();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AktualizujCene();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            AktualizujCene();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Wybierz procesor!");
                return;
            }

            int cenaCPU = 0;
            if (comboBox1.SelectedItem.ToString() == "Intel i5") cenaCPU = 900;
            else if (comboBox1.SelectedItem.ToString() == "Intel i7") cenaCPU = 1400;

            int cenaDysk = 0;
            if (radioButton1.Checked) cenaDysk = 200;
            else if (radioButton2.Checked) cenaDysk = 350;
            else if (radioButton3.Checked) cenaDysk = 500;

            CenaKomputera = cenaCPU + cenaDysk;
            WybranyProcesor = comboBox1.SelectedItem.ToString();
            WybranyDysk = radioButton1.Checked ? "240GB SSD" :
                          radioButton2.Checked ? "500GB SATA" : "1000GB SATA";

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktualizujCene();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
