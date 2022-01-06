using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ооп_лаба_4_часть_2
{
    public partial class Form1 : Form
    {
        Model model;

        public Form1()
        {
            InitializeComponent();

            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);

        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBox_A.Text = model.getA().ToString(); 
            textBox_B.Text = model.getB().ToString();
            textBox_C.Text = model.getC().ToString();

            numericUpDown_A.Value = model.getA();
            numericUpDown_B.Value = model.getB();
            numericUpDown_C.Value = model.getC();

            trackBar_A.Value = model.getA();
            trackBar_B.Value = model.getB();
            trackBar_C.Value = model.getC();
        }

        private void textBox_A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setA(Int32.Parse(textBox_A.Text));
        }

        private void textBox_B_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setB(Int32.Parse(textBox_B.Text));
        }

        private void textBox_C_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setC(Int32.Parse(textBox_C.Text));
        }

        private void numericUpDown_A_ValueChanged(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(numericUpDown_A.Value));
        }

        private void numericUpDown_B_ValueChanged(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(numericUpDown_B.Value));
        }

        private void numericUpDown_C_ValueChanged(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(numericUpDown_C.Value));
        }

        private void trackBar_A_Scroll(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(trackBar_A.Value));
        }

        private void trackBar_B_Scroll(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(trackBar_B.Value));
        }

        private void trackBar_C_Scroll(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(trackBar_C.Value));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.textBoxA_sett = model.getA().ToString();
            Properties.Settings.Default.textBoxB_sett = model.getB().ToString();
            Properties.Settings.Default.textBoxC_sett = model.getC().ToString();

            Properties.Settings.Default.numUpDownA_sett = Decimal.ToInt32(model.getA());
            Properties.Settings.Default.numUpDownB_sett = Decimal.ToInt32(model.getB());
            Properties.Settings.Default.numUpDownC_sett = Decimal.ToInt32(model.getC());

            Properties.Settings.Default.trackBarA_sett = model.getA();
            Properties.Settings.Default.trackBarB_sett = model.getB();
            Properties.Settings.Default.trackBarC_sett = model.getC();

            Properties.Settings.Default.Save();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.textBox_C.Text = Properties.Settings.Default.textBoxC_sett;
            this.textBox_B.Text = Properties.Settings.Default.textBoxB_sett;
            this.textBox_A.Text = Properties.Settings.Default.textBoxA_sett;

            this.numericUpDown_C.Value = Properties.Settings.Default.numUpDownC_sett;
            this.numericUpDown_B.Value = Properties.Settings.Default.numUpDownB_sett;
            this.numericUpDown_A.Value = Properties.Settings.Default.numUpDownA_sett;

            this.trackBar_C.Value = Properties.Settings.Default.trackBarC_sett;
            this.trackBar_B.Value = Properties.Settings.Default.trackBarB_sett;
            this.trackBar_A.Value = Properties.Settings.Default.trackBarA_sett;
        }
    }
}
