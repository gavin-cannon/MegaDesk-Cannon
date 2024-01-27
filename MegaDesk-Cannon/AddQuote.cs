using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Cannon
{
    public partial class AddQuote : Form
    {
        private bool addButtonClicked = false;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            this.CausesValidation = false;
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void WidthNumberUpDown_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown widthNumericUpDown = (NumericUpDown)sender;
            
            // Check if input meets criteria
            if (widthNumericUpDown.Value < Desk.MinWidth || widthNumericUpDown.Value > Desk.MaxWidth || widthNumericUpDown.Value % 1 != 0)
            {
                // Visual Queue To Location Error Area
                widthNumericUpDown.BackColor = Color.LightCoral;
                // Show an error message
                MessageBox.Show("Please enter an integer value between 24 and 96 for width.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set focus to the control to allow correction
                widthNumericUpDown.Focus();

            }
            else
            {
                // Reset the color when there is no error
                widthNumericUpDown.BackColor = SystemColors.Window;
            }
        }

        private void False(object sender, EventArgs e)
        {

        }

        private void DepthNumberUpDown_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown depthNumericUpDown = (NumericUpDown)sender;

            if (depthNumericUpDown.Value < Desk.MinDepth || depthNumericUpDown.Value > Desk.MaxDepth || depthNumericUpDown.Value % 1 != 0)
            {
                // Visual Queue To Location Error Area
                depthNumericUpDown.BackColor = Color.LightCoral;
                // Show an error message box
                MessageBox.Show("Please enter a valid integer value between 12 and 48 for depth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set focus to the control to allow correction
                depthNumericUpDown.Focus();
            }
            else
            {
                // Reset the color when there is no error
                depthNumericUpDown.BackColor = SystemColors.Window;
            }
        }

        private void DepthNumberUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key is a control key (like Backspace) or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press if it's not a digit or a control key
            }
        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            addButtonClicked = true;
            string name = Convert.ToString(FullName.Text);
            int width = Convert.ToInt32(WidthNumberUpDown.Value);
            int depth = Convert.ToInt32(DepthNumberUpDown.Value);
            int drawers = Convert.ToInt32(DrawersNumberUpDown.Value);
            string materialString = DesktopMaterial.SelectedItem as string;
            string rushString = RushOrder.SelectedItem as string;
            DateTime submissionDate = DateTime.Now;
            Desk desk = new Desk(name, width, depth, drawers, materialString, rushString);
            DeskQuote deskQuote = new DeskQuote(desk, submissionDate);
            string quote = deskQuote.QuoteDescription;

            this.Hide();
            DisplayQuote displayQuote = new DisplayQuote(quote);
            displayQuote.Show();
            this.Close();
        }
    }
}
