using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Fileds
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;

  

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRounRectdrgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllips,
            int nHeightEllips
            );
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            BtnPercent.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnPercent.Width, BtnPercent.Height, 15, 15));
            BtnCE.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnCE.Width, BtnCE.Height, 15, 15));
            BtnC.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnC.Width, BtnC.Height, 15, 15));
            BtnBackSpace.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnBackSpace.Width, BtnBackSpace.Height, 15, 15));
            button16.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, button16.Width, button16.Height, 15, 15));
            button17.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, button17.Width, button17.Height, 15, 15));
            BtnSquare.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnSquare.Width, BtnSquare.Height, 15, 15));
            BtnDivison.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnDivison.Width, BtnDivison.Height, 15, 15));
            Btn7.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn7.Width, Btn7.Height, 15, 15));
            Btn8.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn8.Width, Btn8.Height, 15, 15));
            Btn9.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn9.Width, Btn9.Height, 15, 15));
            BtnMultiplication.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnMultiplication.Width, BtnMultiplication.Height, 15, 15));
            Btn4.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn4.Width, Btn4.Height, 15, 15));
            Btn5.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn5.Width, Btn5.Height, 15, 15));
            Btn6.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn6.Width, Btn6.Height, 15, 15));
            BtnSubtraction.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnSubtraction.Width, BtnSubtraction.Height, 15, 15));
            Btn1.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn1.Width, Btn1.Height, 15, 15));
            Btn2.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn2.Width, Btn2.Height, 15, 15));
            Btn3.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn3.Width, Btn3.Height, 15, 15));
            BtnAdd.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnAdd.Width, BtnAdd.Height, 15, 15));
            BtnPM.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnPM.Width, BtnPM.Height, 15, 15));
            Btn0.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, Btn0.Width, Btn0.Height, 15, 15));
            BtnDecimal.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnDecimal.Width, BtnDecimal.Height, 15, 15));
            BtnEquals.Region = Region.FromHrgn(CreateRounRectdrgn(0, 0, BtnEquals.Width, BtnEquals.Height, 15, 15));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Btn(object sender, EventArgs e)
        {

        }

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(TxtDisplay.Text);



            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if(TxtDisplay.Text != "0")
            {
                TxtDisplay2.Text = fstNum = $"{result} {operation}";
                TxtDisplay.Text = string.Empty;
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            pnlHistory.Height = (pnlHistory.Height == 5) ? pnlHistory.Height = 345 : 5;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secNum = TxtDisplay.Text;
            TxtDisplay2.Text = $"{TxtDisplay2.Text} {TxtDisplay.Text} =";
            if (TxtDisplay.Text != string.Empty);
            {
                if (TxtDisplay.Text == "0") TxtDisplay2.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        TxtDisplay.Text = (result + Double.Parse(TxtDisplay.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {TxtDisplay.Text} \n");
                        break;
                    case "-":
                        TxtDisplay.Text = (result - Double.Parse(TxtDisplay.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {TxtDisplay.Text} \n");
                        break;
                    case "x":
                        TxtDisplay.Text = (result * Double.Parse(TxtDisplay.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {TxtDisplay.Text} \n");
                        break;
                    case "÷":
                        TxtDisplay.Text = (result / Double.Parse(TxtDisplay.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {TxtDisplay.Text} \n");
                        break;
                    default: TxtDisplay2.Text = $"{TxtDisplay.Text} = ";
                        break;
                        {
                            result = Double.Parse(TxtDisplay.Text);
                            operation = string.Empty;
                        }
                }

            }

            }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty)
                RtBoxDisplayHistory.Text = "There's no history yet";
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.Length > 0)
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1, 1);
            if (TxtDisplay.Text == string.Empty) TxtDisplay.Text = "0";
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
            TxtDisplay2.Text = string.Empty;
            result = 0;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√x":
                    TxtDisplay2.Text = $"√({TxtDisplay})";
                    TxtDisplay.Text = Convert.ToString(Math.Sqrt(Double.Parse(TxtDisplay.Text)));
                    break;
                case "x²":
                    TxtDisplay2.Text = $"({TxtDisplay})x²";
                    TxtDisplay.Text = Convert.ToString(Convert.ToDouble(TxtDisplay.Text) * Convert.ToDouble(TxtDisplay.Text));
                    break;
                case "1∕x ":
                    TxtDisplay2.Text = $"1∕({TxtDisplay})";
                    TxtDisplay.Text = Convert.ToString(1.0 % Convert.ToDouble(TxtDisplay.Text));
                    break;
                case "%":
                    TxtDisplay2.Text = $"%({TxtDisplay})";
                    TxtDisplay.Text = Convert.ToString(Convert.ToDouble(TxtDisplay.Text) / Convert.ToDouble(100));
                    break;
                case "+/-":
                    TxtDisplay2.Text = $"√({TxtDisplay})";
                    TxtDisplay.Text = Convert.ToString(-1 * Convert.ToDouble(TxtDisplay.Text));
                    break;
            }
            RtBoxDisplayHistory.AppendText($"{TxtDisplay2.Text} = {TxtDisplay.Text} \n");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {

            if (TxtDisplay.Text == "0" || enterValue) TxtDisplay.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay.Text.Contains("."))
                    TxtDisplay.Text = TxtDisplay.Text + button.Text;

            }
            else TxtDisplay.Text = TxtDisplay.Text + button.Text; 
        }
    }
}
