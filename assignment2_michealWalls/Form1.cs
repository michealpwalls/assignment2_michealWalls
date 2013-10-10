using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_michealWalls
{
    public partial class Form_MainWindow : Form
    {
        //Instance variables
        private Color chosenColor;
        private Font chosenFont;
        private Double accessoriesTotal;
        private Double optionsTotal;
        private Double appearanceTotal;

        public Form_MainWindow()
        {
            InitializeComponent();
            accessoriesTotal = 0;
            optionsTotal = 0;
            appearanceTotal = 0;
        }

        private void stripMenuItem_fileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * This method will show the About window to the user.
         */
        private void stripMenu_help_about_Click(object sender, EventArgs e)
        {
            //Instantiate an instance of the About form
            Form_About aboutWindow = new Form_About();

            //Show the About form
            aboutWindow.Show();
        }

        /**
         * This method will show the ColourControl for the user, allowing them to pick a new Colour.
         * The new Colour is then applied to the basePrice and amountDue textBoxes
         */
        private void stripMenu_edit_colour_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            chosenColor = colorDialog.Color;
            textBox_basePrice.ForeColor = textBox_amountDue.ForeColor = chosenColor;
        }// end of stripMenu_edit_colour_Click method

        /**
         * This method will show the FontControl for the user, allowing them to pick a new Font.
         * The new Font is then applied to the basePrice and amountDue textBoxes
         */
        private void stripMenu_edit_font_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            chosenFont = fontDialog.Font;
            textBox_basePrice.Font = textBox_amountDue.Font = chosenFont;
        }// end of stripMenu_edit_font_Click method

        private void button_tabControl_back1_Click(object sender, EventArgs e)
        {
            tabControl_mainFlowControl.SelectedTab = tabPage_start;
        }

        private void button_tabControl_next2_Click(object sender, EventArgs e)
        {
            tabControl_mainFlowControl.SelectedTab = tabPage_accessories;
        }

        private void button_tabControl_back2_Click(object sender, EventArgs e)
        {
            tabControl_mainFlowControl.SelectedTab = tabPage_appearance;
        }

        private void button_tabControl_next3_Click(object sender, EventArgs e)
        {
            tabControl_mainFlowControl.SelectedTab = tabPage_options;
        }

        private void button_tabControl_back3_Click(object sender, EventArgs e)
        {
            tabControl_mainFlowControl.SelectedTab = tabPage_accessories;
        }

        private void button_tabControl_back4_Click(object sender, EventArgs e)
        {
            tabControl_mainFlowControl.SelectedTab = tabPage_options;
        }

        private void button_tabControl_next1_Click(object sender, EventArgs e)
        {
            tabControl_mainFlowControl.SelectedTab = tabPage_appearance;
        }

        /**
         * Calculate entry-point (Menu)
         */
        private void stripMenu_edit_calculate_Click(object sender, EventArgs e)
        {
            calculateTotals();
            tabControl_mainFlowControl.SelectedTab = tabPage_totals;
        }// end of stripMenu_edit_calculate_Click method

        /**
         * Calculate entry-point (Next/Calculate tab button)
         */
        private void button_tabControl_next4_Click(object sender, EventArgs e)
        {
            calculateTotals();
            tabControl_mainFlowControl.SelectedTab = tabPage_totals;
        }// end of button_tabControl_next4_Click method

        /**
         * Clear all the TextBox controls
         */
        private void stripMenu_edit_clear_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }// end of stripMenu_edit_clear_Click method

        private void button_clearInput1_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }

        private void button_clearInput2_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }

        /**
         * This method will reset all TextBox controls to their empty defaults
         */
        private void clearInputFields()
        {
            textBox_additionalOptions.Text = "$0";
            textBox_amountDue.Text = "$0";
            textBox_basePrice.Text = "$0";
            textBox_salesTax.Text = "$0";
            textBox_subTotal.Text = "$0";
            textBox_total.Text = "$0";
            textBox_tradeInAllowance.Text = "$0";
        }// end of clearInputFields method

        private void radioButton_appearance_packages_pureStyle_Click(object sender, EventArgs e)
        {
            this.appearanceTotal = appearanceTotal + 800.00;
        }

        private void radioButton_appearance_packages_none_Click(object sender, EventArgs e)
        {
            this.appearanceTotal = appearanceTotal - 800.00;
        }

        /**
         * Main Calculate method. Sums up all the totals
         */
        private void calculateTotals()
        {
            //The first step is to strip all the dollar-signs from the input fields
            textBox_basePrice.Text = textBox_basePrice.Text.Replace("$", "");
            textBox_tradeInAllowance.Text = textBox_tradeInAllowance.Text.Replace("$", "");

            //The second step is to strip all the commas from the input fields
            textBox_basePrice.Text = textBox_basePrice.Text.Replace(",", "");
            textBox_tradeInAllowance.Text = textBox_tradeInAllowance.Text.Replace(",", "");

            //The third step is to SUM all the relevant input fields
            Double totalContainer;
            try {
                totalContainer = (Convert.ToDouble(textBox_basePrice.Text)
                                + appearanceTotal
                                + optionsTotal
                                + accessoriesTotal)
                                - Convert.ToDouble(textBox_tradeInAllowance.Text);
            } catch(FormatException) {
                totalContainer = 0;
                textBox_subTotal.Text = textBox_total.Text = textBox_amountDue.Text = textBox_salesTax.Text = "Invalid Inputs!";

            }// end of try-catch block

            try {
                textBox_subTotal.Text = "$" + Convert.ToString(totalContainer);
            } catch (FormatException) {
                textBox_subTotal.Text = textBox_total.Text = textBox_amountDue.Text = textBox_salesTax.Text = "Invalid Inputs!";
            }// end of try-catch block

            //TODO: Finish this method..

        }// end of calculateTotals method

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_basePrice.Text = "$24,000";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_basePrice.Text = "$14,000";
        }

        /**
         * 
         * Empty Stubs
         * 
         */
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_appearance_packages_pureStyle_Click(object sender, EventArgs e)
        {

        }


    }
}
