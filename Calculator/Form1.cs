namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string FirstNum, SecondNum;
        bool enterValue = false;
        Double memory = 0;


        public Form1()
        {
            InitializeComponent();
        }
        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textDisplat1.Text == "0")
                textDisplat1.Text = "";
            {
                if (button.Text == ",")
                {
                    if (!textDisplat1.Text.Contains(","))
                        textDisplat1.Text = textDisplat1.Text + button.Text;
                }
                else
                {
                    textDisplat1.Text = textDisplat1.Text + button.Text;
                }
            }
        }
        private void BtmMathOper_Click(object sender, EventArgs e)
        {
            if (result != 0) buttonTOTAL.PerformClick();
            else result = Double.Parse(textDisplat1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (textDisplat1.Text != "0")
            {
                textDisplay2.Text = FirstNum = $"{result}{operation}";
                textDisplat1.Text = string.Empty;
            }
        }
        private void buttonTOTAL_Click(object sender, EventArgs e)
        {
            SecondNum = textDisplat1.Text;
            textDisplay2.Text = $"{textDisplay2.Text}{textDisplat1.Text}";
            if (RTBoxDisplayHistory.Text == "Истории нема")
            {
                RTBoxDisplayHistory.Clear();
            }

            if (textDisplat1.Text != string.Empty)
            {
                if (textDisplat1.Text == "0") textDisplay2.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        textDisplat1.Text = (result + Double.Parse(textDisplat1.Text)).ToString();
                        RTBoxDisplayHistory.AppendText($"{FirstNum}{SecondNum} = {textDisplat1.Text}\n");
                        break;
                    case "-":
                        textDisplat1.Text = (result - Double.Parse(textDisplat1.Text)).ToString();
                        RTBoxDisplayHistory.AppendText($"{FirstNum}{SecondNum} = {textDisplat1.Text}\n");
                        break;
                    case "÷":
                        textDisplat1.Text = (result / Double.Parse(textDisplat1.Text)).ToString();
                        RTBoxDisplayHistory.AppendText($"{FirstNum}{SecondNum} = {textDisplat1.Text}\n");
                        break;
                    case "×": //исправь на умножение
                        textDisplat1.Text = (result * Double.Parse(textDisplat1.Text)).ToString();
                        RTBoxDisplayHistory.AppendText($"{FirstNum}{SecondNum} = {textDisplat1.Text}\n");
                        break;
                    default:
                        textDisplay2.Text = $"{textDisplat1.Text} = ";
                        break;
                }

                result = Double.Parse(textDisplat1.Text);
                operation = string.Empty;
            }
        }
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            panelHistory.Height = (panelHistory.Height == 5) ? panelHistory.Height = 345 : 5;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            RTBoxDisplayHistory.Clear();
            RTBoxDisplayHistory.Text = "Истории нема";
        }
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textDisplat1.Text.Length > 0)
                textDisplat1.Text = textDisplat1.Text.Remove(textDisplat1.Text.Length - 1, 1);
            if (textDisplat1.Text == string.Empty) textDisplat1.Text = "0";
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplat1.Text = "0";
            textDisplay2.Text = string.Empty;
            result = 0;
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textDisplat1.Text = "0";
        }
        private void BtnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            {
                case "%":
                    textDisplay2.Text = $"√({textDisplat1.Text})";
                    textDisplat1.Text = Convert.ToString(Convert.ToDouble(textDisplat1.Text) / Convert.ToDouble(100));
                    break;
                case "√":
                    textDisplay2.Text = $"√({textDisplat1.Text})";
                    textDisplat1.Text = Convert.ToString(Math.Sqrt(Double.Parse(textDisplat1.Text)));
                    break;
                case "±":
                    textDisplat1.Text = Convert.ToString(-1 * Convert.ToDouble(textDisplat1.Text));
                    break;
                case "x²":
                    textDisplay2.Text = $"({textDisplat1.Text})²";
                    textDisplat1.Text = Convert.ToString(Convert.ToDouble(textDisplat1.Text) * Convert.ToDouble(textDisplat1.Text));
                    break;
                case "¹/":
                    textDisplay2.Text = $"¹/({textDisplat1.Text})";
                    textDisplat1.Text = Convert.ToString(1.0 / Convert.ToDouble(textDisplat1.Text));
                    break;
            }
            RTBoxDisplayHistory.AppendText($"{textDisplay2.Text} = {textDisplat1.Text}\n");
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFold_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MemOper_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            Double i = 0;
            switch (operation)
            {
                case "MC":
                    memory = 0;
                    break;
                case "MR":
                    textDisplat1.Text = Convert.ToString(memory);
                    break;
                case "M+":
                    i = Double.Parse(textDisplat1.Text);
                    textDisplay2.Text = $"{i}+{Convert.ToString(memory)}=";
                    textDisplat1.Text = (Double.Parse(textDisplat1.Text) + memory).ToString();
                    RTBoxDisplayHistory.AppendText($"{i}+{memory} = {textDisplat1.Text}\n");
                    break;
                case "M-":
                    i = Double.Parse(textDisplat1.Text);
                    textDisplay2.Text = $"{i}-{Convert.ToString(memory)}=";
                    textDisplat1.Text = (Double.Parse(textDisplat1.Text) - memory).ToString();
                    RTBoxDisplayHistory.AppendText($"{i}-{memory} = {textDisplat1.Text}\n");
                    break;
                case "MS":
                    memory = Double.Parse(textDisplat1.Text);
                    break;
                case "M~":
                    textDisplat1.Text = Convert.ToString(memory);
                    memory = 0;
                    break;
            }

            result = Double.Parse(textDisplat1.Text);
            operation = string.Empty;
        }
    }
}