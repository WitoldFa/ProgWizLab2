﻿using System;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int cenaKomputera = 0;
        int cenaMonitora = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                cenaKomputera = form2.CenaKomputera;
                textBox3.Text = (cenaKomputera + cenaMonitora).ToString(); 
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                cenaMonitora = form3.CenaMonitora;
                textBox3.Text = (cenaKomputera + cenaMonitora).ToString(); 
            }
        }
    }
}
