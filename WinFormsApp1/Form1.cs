namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2= 0;
            operador = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength == 1) textBox1.Text = "0";
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);

            switch (operador)
            {
                case "+":
                    textBox1.Text = $"{num1 + num2}";
                    break;

                case "-":
                    textBox1.Text = $"{num1 - num2}";
                    break;

                case "*":
                    textBox1.Text = $"{num1 * num2}";
                    break;

                case "/":
                    textBox1.Text = $"{num1 / num2}";
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}