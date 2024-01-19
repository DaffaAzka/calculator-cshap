namespace Calculator
{
    public partial class Form1 : Form
    {
        string[] arr = ["0", "0"];
        string act = "";
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("1");
            LoadNewNumber();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("0");
            LoadNewNumber();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNewNumber();
        }


        private void twoButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("2");
            LoadNewNumber();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("3");
            LoadNewNumber();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("4");
            LoadNewNumber();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("5");
            LoadNewNumber();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("6");
            LoadNewNumber();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("7");
            LoadNewNumber();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("8");
            LoadNewNumber();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            SubmitNumber("9");
            LoadNewNumber();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            if (act == "")
            {
                act = "+";
                index = 1;
                LoadNewNumber();
            }
            else
            {
                Solve();
            }
        }

        private void cButton_Click(object sender, EventArgs e)
        {

        }

        private void subButton_Click(object sender, EventArgs e)
        {

        }

        private void multButton_Click(object sender, EventArgs e)
        {

        }

        private void divButton_Click(object sender, EventArgs e)
        {

        }

        private void solveButton_Click(object sender, EventArgs e)
        {

        }


        private void SubmitNumber(string s)
        {
            if (arr[index] == "0")
            {
                arr[index] = s;
            }
            else
            {
                arr[index] += s;
            }
        }

        private void LoadNewNumber()
        {
            if (act == "")
            {
                secondLine.Text = "";
                mainLine.Text = arr[0];
            }
            else
            {
                secondLine.Text = $"{arr[0]} {act}";
                mainLine.Text = arr[1];
            }
        }



        private void Solve()
        {
            int n = 0;
            switch (act)
            {
                case "+":
                    n = int.Parse(arr[0]) + int.Parse(arr[1]);
                    arr[0] = n.ToString();
                    break;
                case "-":
                    n = int.Parse(arr[0]) - int.Parse(arr[1]);
                    arr[0] = n.ToString();
                    break;
                case "*":
                    n = int.Parse(arr[0]) * int.Parse(arr[1]);
                    arr[0] = n.ToString();
                    break;
                case "/":
                    n = int.Parse(arr[0]) / int.Parse(arr[1]);
                    arr[0] = n.ToString();
                    break;
            }
            arr[1] = "0";
            act = "";
            index = 0;
            LoadNewNumber();
        }
    }
}
