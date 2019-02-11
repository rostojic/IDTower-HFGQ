using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDTower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateSkuLabelContent()
        {
            StringBuilder result = new StringBuilder();
            int total = (int)numTotal.Value;
            long startSerial = 0;
            try
            {
                startSerial = long.Parse(txtStartSerail.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Check the string Serial!");
                return;
            }
            if (total > 0)
            {
                for (int i = 0; i < total; i++)
                {
                    result.Append(txtPrefix.Text);
                    result.Append(txtSKU.Text);
                    result.Append(txt310K.Text);
                    result.Append(txtPW.Text);
                    result.Append("13");
                    result.Append(txtDate.Text);
                    result.Append("21");
                    result.Append(startSerial.ToString());
                    result.Append("|");
                    if (checkBox1.Checked)
                    {
                        startSerial++;
                    }
                }
                result.Remove(result.Length - 1, 1);
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Total must be greater than 0!");
            }
        }

        private void GeneratePAID()
        {
            StringBuilder result = new StringBuilder();
            result.Append(txtPAIDpart1.Text);
            result.Append(txtSKU.Text);
            result.Append(txtPAIDpart2.Text);
            result.Append(txtSKU.Text);
            result.Append(txtPAIDpart3.Text);
            txtResultPAID.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateSkuLabelContent();
            GeneratePAID();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

  
        private void txtResultPAID_MouseClick(object sender, MouseEventArgs e)
        {
            txtResultPAID.SelectAll();
        }

        private void txtResult_MouseClick(object sender, MouseEventArgs e)
        {
            txtResult.SelectAll();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).ReadOnly = checkBox2.Checked? true : false;
                }
            }
            txtSKU.ReadOnly = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
