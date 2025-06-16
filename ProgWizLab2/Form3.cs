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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string WybranyMonitor { get; private set; }
        public int CenaMonitora { get; private set; }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                textBox1.Text = "";
                return;
            }

            var wybrany = listView1.SelectedItems[0].Text;

            if (wybrany.Contains("Mon_a")) textBox1.Text = "600";
            else if (wybrany.Contains("Mon_b")) textBox1.Text = "1000";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz monitor!");
                return;
            }

            WybranyMonitor = listView1.SelectedItems[0].Text;

            if (WybranyMonitor.Contains("Mon_a")) CenaMonitora = 600;
            else if (WybranyMonitor.Contains("Mon_b")) CenaMonitora = 1000;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
