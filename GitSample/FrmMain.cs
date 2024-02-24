using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitSample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int text1 = int.Parse(txtExpression1.Text);
                int text2 = int.Parse(txtExpression2.Text);

                txtResult.Text = (text1 + text2).ToString();
            }catch(Exception ex)
            {
                txtResult.Text = "計算できません";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int text1 = int.Parse(txtExpression1.Text);
                int text2 = int.Parse(txtExpression2.Text);

                txtResult.Text = (text1 - text2).ToString();
            }catch(Exception ex)
            {
                txtResult.Text = "計算できません";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int text1 = int.Parse(txtExpression1.Text);
                int text2 = int.Parse(txtExpression2.Text);

                txtResult.Text = (text1 * text2).ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = "計算できません";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                txtResult.Text = caliculationDivision(txtExpression1.Text, txtExpression2.Text).ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = "計算できません";
            }

        }

        private double caliculationDivision(string text1, string text2) {

            if (text1 == null)
            {
                text1 = "0";
            }
            if (text2 == null)
            {
                text2 = "0";
            }

            double bNum1 = double.Parse(text1);
            double bNum2 = double.Parse(text2);



            return bNum1 / bNum2;
        
        }
    }
}
