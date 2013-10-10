/*
 *      Form1.cs
 *      
 *      assignment2_michealWalls - "fun-with-c-sharp"
 *      
 *      Copyright 2013 Micheal Walls <michealpwalls@gmail.com>
 *      
 *      This program is free software; you can redistribute it and/or modify
 *      it under the terms of the GNU General Public License as published by
 *      the Free Software Foundation; either version 2 of the License, or
 *      (at your option) any later version.
 *      
 *      This program is distributed in the hope that it will be useful,
 *      but WITHOUT ANY WARRANTY; without even the implied warranty of
 *      MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *      GNU General Public License for more details.
 *      
 *      You should have received a copy of the GNU General Public License
 *      along with this program; if not, write to the Free Software
 *      Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 *      MA 02110-1301, USA.
 *      
 *      
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_michealWalls {

    public partial class Form_MainWindow : Form {
        //Instance variables
        private Color chosenColor;
        private Font chosenFont;
        private Double accessoriesTotal;
        private Double optionsTotal;
        private Double appearanceTotal;
        private Double salesTax;

        public Form_MainWindow() {
            InitializeComponent();
            accessoriesTotal = 0;
            optionsTotal = 0;
            appearanceTotal = 0;
            salesTax = 0;
        }// end of Form_MainWindow constructor

        private void stripMenuItem_fileExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        /**
         * This method will show the About window to the user.
         */
        private void stripMenu_help_about_Click(object sender, EventArgs e) {
            //Instantiate an instance of the About form
            Form_About aboutWindow = new Form_About();

            //Show the About form
            aboutWindow.Show();
        }

        /**
         * This method will show the ColourControl for the user, allowing them to pick a new Colour.
         * The new Colour is then applied to the basePrice and amountDue textBoxes
         */
        private void stripMenu_edit_colour_Click(object sender, EventArgs e) {
            colorDialog.ShowDialog();
            chosenColor = colorDialog.Color;
            textBox_basePrice.ForeColor = textBox_amountDue.ForeColor = chosenColor;
        }// end of stripMenu_edit_colour_Click method

        /**
         * This method will show the FontControl for the user, allowing them to pick a new Font.
         * The new Font is then applied to the basePrice and amountDue textBoxes
         */
        private void stripMenu_edit_font_Click(object sender, EventArgs e) {
            fontDialog.ShowDialog();
            chosenFont = fontDialog.Font;
            textBox_basePrice.Font = textBox_amountDue.Font = chosenFont;
        }// end of stripMenu_edit_font_Click method

        /********************************************
         * Event handlers for the Next/Back buttons *
         ********************************************/
        private void button_tabControl_back1_Click(object sender, EventArgs e) {
            tabControl_mainFlowControl.SelectedTab = tabPage_start;
        }

        private void button_tabControl_next2_Click(object sender, EventArgs e) {
            tabControl_mainFlowControl.SelectedTab = tabPage_accessories;
        }

        private void button_tabControl_back2_Click(object sender, EventArgs e) {
            tabControl_mainFlowControl.SelectedTab = tabPage_appearance;
        }

        private void button_tabControl_next3_Click(object sender, EventArgs e) {
            tabControl_mainFlowControl.SelectedTab = tabPage_options;
        }

        private void button_tabControl_back3_Click(object sender, EventArgs e) {
            tabControl_mainFlowControl.SelectedTab = tabPage_accessories;
        }

        private void button_tabControl_back4_Click(object sender, EventArgs e) {
            tabControl_mainFlowControl.SelectedTab = tabPage_options;
        }

        private void button_tabControl_next1_Click(object sender, EventArgs e) {
            tabControl_mainFlowControl.SelectedTab = tabPage_appearance;
        }

        /**
         * Calculate entry-point (Menu)
         */
        private void stripMenu_edit_calculate_Click(object sender, EventArgs e) {
            calculateTotals();
            tabControl_mainFlowControl.SelectedTab = tabPage_totals;
        }// end of stripMenu_edit_calculate_Click method

        /**
         * Calculate entry-point (Next/Calculate tab button)
         */
        private void button_tabControl_next4_Click(object sender, EventArgs e) {
            calculateTotals();
            tabControl_mainFlowControl.SelectedTab = tabPage_totals;
        }// end of button_tabControl_next4_Click method

        /**
         * Calculate entry-point (totals tab OnFocus)
         */
        private void tabPage_totals_OnFocus(object sender, EventArgs e) {
            //If the currently selected tab is the Totals tab, call the calculateTotals method
            if (tabControl_mainFlowControl.SelectedTab == tabPage_totals) {
                calculateTotals();
            }
        }// end of tabPage_totals_OnFocus method

        /*************************************************
         * Event handlers for the Clear button/menu item *
         *************************************************/
        private void stripMenu_edit_clear_Click(object sender, EventArgs e) {
            clearInputFields();
        }// end of stripMenu_edit_clear_Click method

        private void button_clearInput1_Click(object sender, EventArgs e) {
            clearInputFields();
        }// end of button_clearInput1_Click method

        private void button_clearInput2_Click(object sender, EventArgs e) {
            clearInputFields();
        }// end of button_clearInput2_Click method

        /**
         * This method will reset all TextBox controls to their empty defaults
         */
        private void clearInputFields() {
            textBox_additionalOptions.Text = "$0";
            textBox_amountDue.Text = "$0";
            textBox_basePrice.Text = "$0";
            textBox_salesTax.Text = "$0";
            textBox_subTotal.Text = "$0";
            textBox_total.Text = "$0";
            textBox_tradeInAllowance.Text = "$0";
        }// end of clearInputFields method

        /**********************************************
         * Event handlers for the Appearance packages *
         **********************************************/
        private void radioButton_appearance_packages_pureStyle_Click(object sender, EventArgs e) {
            this.appearanceTotal = appearanceTotal + 800.00;
        }// end of radioButton_appearance_packages_pureStyle_Click method

        private void radioButton_appearance_packages_none_Click(object sender, EventArgs e) {
            this.appearanceTotal = appearanceTotal - 800.00;
        }// end of radioButton_appearance_packages_none_Click method

        /**
         * 
         */
        private void calculateSalesTax(Double totalContainer) {
            try {
                salesTax = totalContainer * 0.13;
                textBox_salesTax.Text = "$" + Convert.ToString(salesTax);
            } catch (FormatException) {
                textBox_salesTax.Text = textBox_total.Text = textBox_amountDue.Text = textBox_subTotal.Text = "Invalid Inputs!";
            }// end of try-catch block
        }// end of calculateSalesTax method

        /**
         * Main Calculate method. Sums up all the totals,
         * subtract trade-in allowance and apply the sales tax
         */
        private void calculateTotals() {
            //The first step is to strip all the dollar-signs and commas from the input fields
            textBox_basePrice.Text = textBox_basePrice.Text.Replace("$", "");
            textBox_tradeInAllowance.Text = textBox_tradeInAllowance.Text.Replace("$", "");
            textBox_basePrice.Text = textBox_basePrice.Text.Replace(",", "");
            textBox_tradeInAllowance.Text = textBox_tradeInAllowance.Text.Replace(",", "");

            //The third step is to SUM all the relevant input fields and subtract the trade in allowance
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

            calculateSalesTax(totalContainer);

            // Update the amountDue TextBox with the tradeInAllowance (For reference, I guess?)
            textBox_amountDue.Text = textBox_tradeInAllowance.Text;

            // Update the total TextBox with the additional salesTax and tradeIn discounted
            try {
                textBox_total.Text = "$" + Convert.ToString(totalContainer + salesTax);
            } catch (FormatException) {
                textBox_total.Text = textBox_salesTax.Text = textBox_amountDue.Text = textBox_subTotal.Text = "Invalid Inputs!";
            }// end of try-catch block
        }// end of calculateTotals method

        /***********************************************
         * Event Handlers for the Base Price pictures  *
         ***********************************************/
        private void pictureBox2_Click(object sender, EventArgs e) {
            textBox_basePrice.Text = "$24,000";
        }// end of pictureBox2_Click method

        private void pictureBox3_Click(object sender, EventArgs e) {
            textBox_basePrice.Text = "$14,000";
        }// end of pictureBox3_Click method

        /************************************
         *  Event Handlers for the Options  *
         ************************************/
        private void checkBox_options_heatedSeats_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_heatedSeats.Checked) {
                optionsTotal += 340.00;
            } else {
                optionsTotal -= 340.00;
            }
        }// end of checkBox_options_heatedSeats_CheckedChanged method

        private void checkBox_options_centreConsole_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_centreConsole.Checked) {
                optionsTotal += 340.00;
            } else {
                optionsTotal -= 340.00;
            }// end of mutually exclusive if..else
        }// end of checkBox_options_centreConsole_CheckedChanged method

        private void checkBox_options_touchScreen_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_touchScreen.Checked) {
                optionsTotal += 1295.00;
            } else {
                optionsTotal -= 1295.00;
            }// end of mutually exclusive if..else
        }// end of checkBox_options_touchScreen_CheckedChanged method

        private void checkBox_options_surroundSystem_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_surroundSystem.Checked) {
                optionsTotal += 590.00;
            } else {
                optionsTotal -= 590.00;
            }// end of mutually exclusive if..else
        }// end of checkBox_options_surroundSystem_CheckedChanged method

        private void checkBox_options_runningLights_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_runningLights.Checked) {
                optionsTotal += 290.00;
            } else {
                optionsTotal -= 290.00;
            }// end of mutually exclusive if..else
        }// end of checkBox_options_runningLights_CheckedChanged method

        private void checkBox_options_iPod_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_iPod.Checked) {
                optionsTotal += 175.00;
            } else {
                optionsTotal -= 175.00;
            }// end of mutually exclusive if..else
        }// end of checkBox_options_iPod_CheckedChanged method

        private void checkBox_options_bluetoothPackage_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_bluetoothPackage.Checked) {
                optionsTotal += 450.00;
            } else {
                optionsTotal -= 450.00;
            }// end of mutually exclusive if..else
        }// end of checkBox_options_bluetoothPackage_CheckedChanged method

    }// end of Form_MainWindow Class

}// end of assignment2_michealWalls namespace