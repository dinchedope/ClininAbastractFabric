using Clinik.Clinik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BadClinik badClinik = new BadClinik();
            NormalClinik normalClinik = new NormalClinik();
            TopClinik topClinik = new TopClinik();

            comboBox1.Items.Clear();

            comboBox1.Items.Add(badClinik);
            comboBox1.Items.Add(normalClinik);
            comboBox1.Items.Add(topClinik);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((AbstractClinik)comboBox1.SelectedItem).GetInjection().Do();
            textBox2.Text = ((AbstractClinik)comboBox1.SelectedItem).GetSurvey().Do();
            textBox3.Text = ((AbstractClinik)comboBox1.SelectedItem).GetTablet().Do();
        }
    }
}
