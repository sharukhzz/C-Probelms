using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
     
        private int PanelHeight;
        private int ButtonWidth;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelHeight = panel1.Height / 6;
            ButtonWidth = panel1.Width / 5;

            panel4.Height = PanelHeight;
            panel2.Height = PanelHeight;
            panel3.Height = PanelHeight;
            panel5.Height = PanelHeight;
            panel6.Height = PanelHeight;
            panel7.Height = PanelHeight;
            button1.Width = ButtonWidth;
            button2.Width = ButtonWidth;
            button3.Width = ButtonWidth;
            button4.Width = ButtonWidth;
            button5.Width = ButtonWidth;
            button6.Width = ButtonWidth;
            button7.Width = ButtonWidth;
            button8.Width = ButtonWidth;
            button9.Width = ButtonWidth;
            button10.Width = ButtonWidth;
            button11.Width = ButtonWidth;
            button12.Width = ButtonWidth;
            button13.Width = ButtonWidth;
            button14.Width = ButtonWidth;
            button15.Width = ButtonWidth;
            button16.Width = ButtonWidth;
            button17.Width = ButtonWidth;
            button18.Width = ButtonWidth;
            button19.Width = ButtonWidth;
            button20.Width = ButtonWidth;
            button21.Width = ButtonWidth;
            button22.Width = ButtonWidth;
            button23.Width = ButtonWidth;
            button24.Width = ButtonWidth;
            button25.Width = ButtonWidth;
        }
        private static int flag = 0;
        private bool isdot;
        private void RichTextBox1KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] opt = new char[] { '+', '-','*','/','%','.','!' };
            if (e.KeyChar == '.' && isdot) e.Handled = true;
            if (richTextBox.Text.Contains(".") && char.IsDigit(e.KeyChar)) isdot = true;
            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '%' || e.KeyChar == '!') isdot = false;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != '%' && e.KeyChar != '.' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
            else if (opt.Contains(e.KeyChar) && richTextBox.Text.Length == 0) e.Handled = true;
            else if (opt.Contains(e.KeyChar))
            {
                if (opt.Contains(richTextBox.Text[richTextBox.Text.Length - 1])) e.Handled = true;
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            char[] opt = new char[] { '+', '-', '*', '/', '%', '.', '!' };
            if (richTextBox.Text == "0" ) richTextBox.Clear();
            
            Button b = sender as Button;
            if (b.Text == ".")
            {
                if (richTextBox.Text.Length == 0) richTextBox.Clear();
                else if (opt.Contains(richTextBox.Text[richTextBox.Text.Length - 1]))
                {

                }
                else if (flag == 0)
                {
                    richTextBox.Text += b.Text;
                }
                flag = 1;
            }
            else  richTextBox.Text += b.Text;

        }

        private void OperatorClick(object sender, EventArgs e)
        {
            char[] opt = new char[] { '+', '-', '*', '/', '%', '.', '!' };
            Button b = sender as Button;
           if (richTextBox.Text.Length != 0 && ! opt.Contains(richTextBox.Text[richTextBox.Text.Length-1] ))
           {
                richTextBox.Text += b.Text;
            }
            flag = 0;
        }

        private void CEClick(object sender, EventArgs e)
        {
            int l = richTextBox.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/', '%', '.', '!' });
            if(l>0)
            {
                richTextBox.Text = richTextBox.Text.Substring(0, l + 1);
            }
            else
            {
                richTextBox.Text = "";
            }
        }
        private void CClick(object sender, EventArgs e)
        {
            richTextBox.Text = "";
        }

        private void Equaltoclick(object sender, EventArgs e)
        {
            richTextBox.Text = Solver.BODMAS(richTextBox.Text).ToString();

        }

        private void RichTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Equaltoclick(sender, e);
            }
        }

        private void BackspaceClick(object sender, EventArgs e)
        {
            if (richTextBox.TextLength > 0)
            {
                richTextBox.Text = richTextBox.Text.Substring(0, richTextBox.Text.Length - 1);
            }
        }

        private void FactClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int number = 0 ;
            if (int.TryParse(richTextBox.Text, out number))
            {
                richTextBox.Text += b.Text;
                long factorialResult = CalculateFactorial(number);
                richTextBox.Text = factorialResult.ToString();
            }
        }   
        private long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        private void SqrtClick(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(richTextBox.Text, out number))
            {
                double sqrtResult = CalculateSquareRoot(number);
                richTextBox.Text =sqrtResult.ToString();
            }
        }
        private double CalculateSquareRoot(double n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Square root is not defined for negative numbers.");
            }

            return Math.Sqrt(n);
        }
    }
    class Solver
    {
        public static float BODMAS(string s)
        {
            int open = s.IndexOf('(');
            int close = s.LastIndexOf(')');
            if ((open != -1 && close == -1) || (open == -1 && close != -1) || s.Length == 0) throw new InvalidExpressionException();
            if (open == -1) return RemoveDivMul(s);

            float ans = BODMAS(s.Substring(open + 1, close - open - 1));

            s = s.Substring(0, open) + ans.ToString() + s.Substring(close + 1);
            return RemoveDivMul(s);
        }

        public static float AddSub(string s)
        {
            List<float> plus = new List<float>();
            List<float> minus = new List<float>();
            int right = (s[0] == '-') ? 1 : 0;
            string var = "";
            int flag = s[0] == '-' ? 1 : 0;
            while (right < s.Length)
            {
                if (char.IsDigit(s[right]) || s[right] == '.') var += s[right++];
                else
                {
                    if (flag == 0) plus.Add(float.Parse(var));
                    else minus.Add(float.Parse(var));

                    if (s[right++] == '+') flag = 0;
                    else flag = 1;

                    var = "";
                }
            }
            if (flag == 0) plus.Add(float.Parse(var));
            else minus.Add(float.Parse(var));

            float pos = 0;
            plus.ForEach(num => pos += num);
            float min = 0;
            minus.ForEach(num => min += num);

            return pos - min;
        }

        public static float RemoveDivMul(string s)
        {
            int right = 0;
            string var1 = "";
            string var2 = "";
            bool flag = false;
            int div = -1;
            string result = "";
            while (right < s.Length)
            {
                if (char.IsDigit(s[right]) || s[right] == '.')
                {
                    if (!flag) var1 += s[right++];
                    else var2 += s[right++];
                }
                else
                {
                    if (flag)
                    {
                        //float res = (div == 0) ? float.Parse(var1) / float.Parse(var2) : float.Parse(var1) * float.Parse(var2);

                        float res;
                        if (div == 0) res = float.Parse(var1) / float.Parse(var2);
                        else if (div == 1) res = float.Parse(var1) * float.Parse(var2);
                        else res = float.Parse(var1) % float.Parse(var2);

                        if (s[right] == '/' || s[right] == '*' || s[right]=='%')
                        {
                            //div = (s[right] == '/') ? 0 : 1;
                            if (s[right] == '/') div = 0;
                            else if (s[right] == '*') div = 1;
                            else div = 2;

                            flag = true;
                            var1 = res.ToString();
                            var2 = "";
                        }
                        else
                        {
                            div = -1;
                            result += res.ToString() + s[right];
                            flag = false;
                            var1 = "";
                            var2 = "";
                        }
                        right++;
                    }
                    else
                    {
                        if (s[right] == '/' || s[right] == '*' || s[right]=='%')
                        {
                            flag = true;
                            //div = (s[right] == '/') ? 0 : 1;
                            if (s[right] == '/') div = 0;
                            else if (s[right] == '*') div = 1;
                            else div = 2;
                        }
                        else
                        {
                            result += var1 + s[right];
                            flag = false;
                            var1 = "";
                            var2 = "";
                        }
                        right++;
                    }
                }
            }

            if (flag)
            {
                float res;
                if (div == 0) res = float.Parse(var1) / float.Parse(var2);
                else if (div == 1) res = float.Parse(var1) * float.Parse(var2);
                else res = float.Parse(var1) % float.Parse(var2);
                result += res.ToString();
            }
            else result += var1;
            return AddSub(result);
        }
    }

}
