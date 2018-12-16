using System;
using System.Linq;
using System.Windows.Forms;

namespace ReedMullerCodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Reed Muller Codes";
            Initialize();
        }

        public void Initialize()
        {
            this.vectorPanel.Visible = false;
        }

        private void onVectorClick(object sender, EventArgs e)
        {
            probabilityLabel.Visible = false;
            probabilityTextBox.Visible = false;
            probabilityButton.Visible = false;
            encodedVector.Visible = false;
            encodedVectorTextBox.Visible = false;
            sendVectorButton.Visible = false;
            receivedVector.Visible = false;
            receivedVectorTextBox.Visible = false;
            decodeVectorButton.Visible = false;
            decodedVectorTextBox.Visible = false;
            decodedVectorLabel.Visible = false;
            enterVectorLabel.Visible = false;
            enterVectorTextBox.Visible = false;
            enterVectorSubmit.Visible = false;
            vectorPanel.Visible = true;
        }

        private void EnterVector_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b01".Contains(e.KeyChar));
        }

        private void VectorEnter_OnClick(object sender, EventArgs e)
        {
            probabilityLabel.Visible = true;
            probabilityTextBox.Visible = true;
            probabilityButton.Visible = true;
        }

        private void Parameters_OnClick(object sender, EventArgs e)
        {
            enterVectorLabel.Visible = true;
            enterVectorTextBox.Visible = true;
            enterVectorSubmit.Visible = true;
        }

        private void ParameterR_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            var isDigit = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
                return;
            }

            if (parameterMTextBox.Text == "")
            {
                MessageBox.Show("Enter M parameter first.");
                e.Handled = true;
                return;
            }
        }

        private void ParameterMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
