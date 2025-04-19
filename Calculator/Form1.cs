using System.Linq.Expressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        enum Operation { add, subtract, multiply, divide, none };
        string currentInput = "";
        double result = 0;
        bool operatorPending = false;
        Operation currentOperation = Operation.none;
        string expression = "";

        void Update_after_operation(Operation op)
        {
            string opChar = "";
            switch (op)
            {
                case Operation.add: opChar = "+"; break;
                case Operation.subtract: opChar = "-"; break;
                case Operation.multiply: opChar = "*"; break;
                case Operation.divide: opChar = "/"; break;
            }

            if (currentInput != "")
            {
                expression += opChar;
                currentInput = "";
                textBox.Text = expression;
            }
        }

        void Input_Numbers(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            expression += button.Text;
            textBox.Text = expression;

        }
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            expression = "";
            currentInput = "";
            textBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Input_Numbers(sender, e);
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Update_after_operation(Operation.add);
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Update_after_operation(Operation.subtract);
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Update_after_operation(Operation.multiply);
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Update_after_operation(Operation.divide);
        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {
           
            try
            {
                var result = new System.Data.DataTable().Compute(expression, null);
                textBox.Text = result.ToString();
                expression = result.ToString();
                currentInput = expression;
            }
            catch
            {
                textBox.Text = "Error";
                expression = "";
                currentInput = "";
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                expression += ".";
                textBox.Text = expression;
            }
        }
    }
}
