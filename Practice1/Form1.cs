namespace Practice1
{
    public partial class PraticeCalcu : Form
    {
        public PraticeCalcu()
        {
            InitializeComponent();

        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnCalculate_Click(object sender, EventArgs e)
        {
            Operation op = new Operation();

            if (txtFirstNumber.Text == "" || txtSecondNumber.Text == "")
            {
                MessageBox.Show("Please enter the number");
            }

            else if (txtOperator.Text == "")
            {
                MessageBox.Show("Please enter the operator");
            }

            else
            {

                double fNum = Convert.ToDouble(txtFirstNumber.Text);
                double sNum = Convert.ToDouble(txtSecondNumber.Text);

                if (txtOperator.Text == "+")
                {

                    lblResult.Text = op.Add(fNum, sNum).ToString();

                }

                else if (txtOperator.Text == "-")
                {
                    if (fNum <= sNum)
                    {
                        MessageBox.Show("Invalid");
                        txtFirstNumber.Clear();
                        txtSecondNumber.Clear();
                        txtOperator.Clear();
                    }

                    else
                    {
                        lblResult.Text = op.Sub(fNum, sNum).ToString();
                    }

                }
                else if (txtOperator.Text == "*")
                {
                    lblResult.Text = op.Mul(fNum, sNum).ToString();
                }

                else if (txtOperator.Text == "/")
                {

                    if (fNum == 0 && sNum == 0 || sNum == 0 || fNum == 0)
                    {
                        MessageBox.Show("Cannot be divided");
                    }
                    lblResult.Text = op.Div(fNum, sNum).ToString();
                }

            }

        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
      !char.IsDigit(e.KeyChar) &&
      e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            TextBox txt = (TextBox)sender;

            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
      !char.IsDigit(e.KeyChar) &&
      e.KeyChar != '.')

            {
                e.Handled = true;
            }

            // Allow only one decimal point
            TextBox txt = (TextBox)sender;

            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOperator.Text = "+";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtOperator.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            txtOperator.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtOperator.Text = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtOperator.Clear();
        }

        private void PraticeCalcu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                btnCalculate.PerformClick();
            }
        }

        private void PraticeCalcu_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void PraticeCalcu_Load(object sender, EventArgs e)
        {

        }
    }
}
