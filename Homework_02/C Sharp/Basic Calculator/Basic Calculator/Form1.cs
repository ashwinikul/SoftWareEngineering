using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Calculator : Form
    {
        Double Num = 0;
        String Operation = "";
        Boolean Op_press = false;
        Double res = 0;
        int op_cnt = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (Op_press == true))
            {
                result.Clear();
            }


            Button B = (Button)sender;
            if (B.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text = result.Text + B.Text;
                   // equation.Text = result.Text + " " + B.Text;
                }

            }
            else
            { 
                result.Text = result.Text + B.Text;
               // equation.Text = result.Text + " " + B.Text;
            }
            Op_press = false;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            result.Text="0";
        }

        private void OP_click(object sender, EventArgs e)
        {
          
           
            if (Op_press == false)
            {
                op_cnt = op_cnt + 1;
                if (op_cnt > 1)
                {
                    Equal.PerformClick();
                    op_cnt = 1;
                    Num = res;
                }
                else
                    Num = Double.Parse(result.Text);


                Button B = (Button)sender;


                Operation = B.Text;
                
                Op_press = true;
                equation.Text = equation.Text + " " + result.Text + " " + Operation;
                

            }

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (Operation == "/" && Double.Parse(result.Text) == 0)
                result.Text = "Cannot Divide By Zero";
            else
            {
                switch (Operation)
                {
                    case "+":
                        res = (Num + Double.Parse(result.Text));
                        break;
                    case "-":
                        res = (Num - Double.Parse(result.Text));
                        break;
                    case "*":
                        res = (Num * Double.Parse(result.Text));
                        break;
                    case "/":
                        res = (Num / Double.Parse(result.Text));
                        break;
                    default:
                        break;
                }// switch ends
                if (op_cnt == 1)
                {
                    C.PerformClick();
                    result.Text = res.ToString();
                    res = 0;

                }
            }
           // Op_press = false;
        }

        private void C_Click(object sender, EventArgs e)
        {
            result.Clear();
            equation.Clear();
            Num = 0;
            Operation = "";
            op_cnt = 0;
            Op_press = false;
        }

      
    }
}
