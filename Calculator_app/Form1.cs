using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double hasiltemp;
        char lambangoperator;
        bool operatorditekan;
        bool samadenganditekan = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fokus()
        {
            textutama.Focus();
            textutama.Select(textutama.Text.Length, 1);
        }

        private void clearkan()
        {
            textutama.Text = "0";
            texttemp.Text = "";
            hasiltemp = 0;
            lambangoperator = ' ';
            operatorditekan = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clearkan();
            fokus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if(textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
            
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn1.Text;
            operatorditekan = false;
            fokus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
              
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn2.Text;
            operatorditekan = false;
            fokus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
                
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn3.Text;
            operatorditekan = false;
            fokus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
              
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn4.Text;
            operatorditekan = false;
            fokus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
               
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn5.Text;
            operatorditekan = false;
            fokus();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
                
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn6.Text;
            operatorditekan = false;
            fokus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
               
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn7.Text;
            operatorditekan = false;
            fokus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn8.Text;
            operatorditekan = false;
            fokus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn9.Text;
            operatorditekan = false;
            fokus();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textutama.Text == "0" || samadenganditekan == true)
            {
                textutama.Clear();
                samadenganditekan = false;
            }
            if (textutama.Text == "=")
            {
                textutama.Clear();
                lambangoperator = ' ';
                hasiltemp = 0;
            }
            textutama.Text = textutama.Text + btn0.Text;
            operatorditekan = false;
            fokus();
        }

        private void btnkoma_Click(object sender, EventArgs e)
        {
            if(textutama.Text.Contains(',') == false)
            {
                textutama.Text = textutama.Text + ",";
            }
            if(lambangoperator == '=')
            {
                hasiltemp = 0;
                lambangoperator = ' ';
                operatorditekan = false;
                samadenganditekan = false;
            }
            fokus();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textutama. Text = (Convert.ToDouble(textutama.Text) * -1).ToString();
            fokus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            clearkan();
            fokus();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textutama.Text = "0";
            if(lambangoperator == '=')
            {
                hasiltemp = 0;
                lambangoperator = ' ';
                operatorditekan = false;
            }
            fokus();
        }

        private void btnkd_Click(object sender, EventArgs e)
        {
            textutama.Text = textutama.Text.Remove(textutama.Text.Length - 1);
            if((textutama.Text == "") || (textutama.Text == "-"))
            {
                textutama.Text = "0";
            }
            if(lambangoperator == '=')
            {
                lambangoperator = ' ';
                hasiltemp = 0;
                operatorditekan = false;
            }
            fokus();
        
        }

        private void btnoperator_Click(object sender, EventArgs e)
        {
            Button btnop = (Button)sender;
            if(operatorditekan == false)
            {
                if (texttemp.Text == "")
                {
                    hasiltemp = Convert.ToDouble(textutama.Text);
                }
                else
                {
                    if (lambangoperator == '+')
                    {
                        hasiltemp = hasiltemp + Convert.ToDouble(textutama.Text);
                    }
                    else if (lambangoperator == '-')
                    {
                        hasiltemp = hasiltemp - Convert.ToDouble(textutama.Text);
                    }
                    else if (lambangoperator == ':')
                    {
                        hasiltemp = hasiltemp / Convert.ToDouble(textutama.Text);
                    }
                    else if (lambangoperator == 'X')
                    {
                        hasiltemp = hasiltemp * Convert.ToDouble(textutama.Text);
                    }
                }
            }
            if(btnop.Text == "=")
            {
                texttemp.Text = "";
                
                textutama.Text = hasiltemp.ToString();
                samadenganditekan = true;
            }
            else
            {
                texttemp.Text = hasiltemp.ToString() + btnop.Text;
                textutama.Text = "0";
                samadenganditekan = false;
            }
            
            lambangoperator = Convert.ToChar(btnop.Text);
            operatorditekan = true;
            fokus();
        }
    }
}
