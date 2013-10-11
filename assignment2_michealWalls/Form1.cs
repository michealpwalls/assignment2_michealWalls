/*
 *      Form1.cs    - v0.1
 *      
 *      assignment2_michealWalls - "fun-with-c-sharp"
 *      
 *      Simple Smart Car designer and price calculator
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
        private Double accessoriesTotal, optionsTotal, appearanceTotal, salesTax;

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
         * Shared Event Handler for the Calculate actions
         */
        private void calculateTotals_sharedHandler(object sender, EventArgs e) {
            tabControl_mainFlowControl.SelectedTab = tabPage_totals;
        }// end of calculateTotals_sharedHandler method

        /**
         * Event Handler for totals tab (OnFocus event)
         */
        private void tabPage_totals_OnFocus(object sender, EventArgs e) {
            // If the currently selected tab is the Totals tab, call the calculateTotals method
            if (tabControl_mainFlowControl.SelectedTab == tabPage_totals) {
                calculateTotals();
            }
        }// end of tabPage_totals_OnFocus method

        /**
         * Shared Event handler for the Clear actions
         */
        private void clearInputFields(object sender, EventArgs e) {
            // Base Price and Trade-In Inputs
            textBox_additionalOptions.Text = textBox_amountDue.Text = textBox_basePrice.Text = "$0";
            textBox_salesTax.Text = textBox_subTotal.Text = textBox_total.Text = textBox_tradeInAllowance.Text = "$0";

            // Accessories Inputs
            checkBox_accessories_chromePackage.Checked = checkBox_accessories_frontSpoiler.Checked = checkBox_accessories_rearApron.Checked = false;
            checkBox_accessories_rearRack.Checked = checkBox_accessories_roofSpoiler.Checked = checkBox_accessories_sideSkirts.Checked = checkBox_accessories_sportExhaust.Checked = false;

            // Options Inputs
            checkBox_options_bluetoothPackage.Checked = checkBox_options_centreConsole.Checked = checkBox_options_heatedSeats.Checked = false;
            checkBox_options_iPod.Checked = checkBox_options_runningLights.Checked = checkBox_options_surroundSystem.Checked = checkBox_options_touchScreen.Checked = false;

            // Appearance Input
            radioButton_appearance_packages_none.Checked = true;

            // Reset the appearanceTotal
            appearanceTotal = 0;
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
         * This method calculates the Sales Tax and puts the value in the Sales Tax TextBox
         */
        private void calculateSalesTax(Double totalContainer) {
            salesTax = totalContainer * 0.13;
            textBox_salesTax.Text = "$" + Convert.ToString(salesTax);
        }// end of calculateSalesTax method

        /**
         * Main Calculate method. Sums up all the totals,
         * subtract trade-in allowance and apply the sales tax
         */
        private void calculateTotals() {
            // Calculation variables
            Double basePrice, additionalOptions, subTotal, total, tradeInAllowance;
            // State of the Calculation
            Boolean calculationState = true;

            //The first step is to strip all the dollar-signs and commas from the input fields
            textBox_basePrice.Text = textBox_basePrice.Text.Replace("$", "");
            textBox_tradeInAllowance.Text = textBox_tradeInAllowance.Text.Replace("$", "");
            textBox_basePrice.Text = textBox_basePrice.Text.Replace(",", "");
            textBox_tradeInAllowance.Text = textBox_tradeInAllowance.Text.Replace(",", "");

            // Calculate the Additional Options and set the value in the TextBox
            additionalOptions = appearanceTotal + optionsTotal + accessoriesTotal;
            textBox_additionalOptions.Text = "$" + Convert.ToString(additionalOptions);

            // Get the user's input in a try-catch block
            try {
                // Get the Base Price
                basePrice = Convert.ToDouble(textBox_basePrice.Text);
                
                //Calculate the subTotal
                subTotal = (basePrice + additionalOptions);

                // Get the trade-in allowance
                tradeInAllowance = Convert.ToDouble(textBox_tradeInAllowance.Text);
            } catch(FormatException) {
                subTotal = 0;
                tradeInAllowance = 0;
                basePrice = 0;
                calculationState = false;
            }// end of try-catch block
            
            // Calculate the Sales Tax and populate the salesTax variable
            calculateSalesTax(subTotal);

            // Calculated the total and update the TextBox
            total = subTotal + salesTax;

            // Control output based on calculationState variable
            if (!calculationState) {
                textBox_subTotal.Text = textBox_total.Text = textBox_amountDue.Text = textBox_additionalOptions.Text = textBox_salesTax.Text = "Invalid Inputs!";
            } else {
                // Update the TextBox fields
                textBox_subTotal.Text = "$" + Convert.ToString(subTotal);
                textBox_total.Text = "$" + Convert.ToString(total);
                textBox_amountDue.Text = "$" + Convert.ToString(total - tradeInAllowance);
            }// end of if

            // Set the picture in the Total tab to reflect the picture they chose on the first tab
            if( basePrice == 24000 ) {
                pictureBox_total.Image = pictureBox2.Image;
                pictureBox_total.Width = 116;
                pictureBox_total.Height = 71;
            } else {
                pictureBox_total.Image = pictureBox3.Image;
                pictureBox_total.Width = 100;
                pictureBox_total.Height = 71;
            }// end of if..else
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
            }// end of if..else
        }// end of checkBox_options_heatedSeats_CheckedChanged method

        private void checkBox_options_centreConsole_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_centreConsole.Checked) {
                optionsTotal += 340.00;
            } else {
                optionsTotal -= 340.00;
            }// end of if..else
        }// end of checkBox_options_centreConsole_CheckedChanged method

        private void checkBox_options_touchScreen_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_touchScreen.Checked) {
                optionsTotal += 1295.00;
            } else {
                optionsTotal -= 1295.00;
            }// end of if..else
        }// end of checkBox_options_touchScreen_CheckedChanged method

        private void checkBox_options_surroundSystem_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_surroundSystem.Checked) {
                optionsTotal += 590.00;
            } else {
                optionsTotal -= 590.00;
            }// end of if..else
        }// end of checkBox_options_surroundSystem_CheckedChanged method

        private void checkBox_options_runningLights_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_runningLights.Checked) {
                optionsTotal += 290.00;
            } else {
                optionsTotal -= 290.00;
            }// end of if..else
        }// end of checkBox_options_runningLights_CheckedChanged method

        private void checkBox_options_iPod_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_iPod.Checked) {
                optionsTotal += 175.00;
            } else {
                optionsTotal -= 175.00;
            }// end of if..else
        }// end of checkBox_options_iPod_CheckedChanged method

        private void checkBox_options_bluetoothPackage_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_options_bluetoothPackage.Checked) {
                optionsTotal += 450.00;
            } else {
                optionsTotal -= 450.00;
            }// end of if..else
        }// end of checkBox_options_bluetoothPackage_CheckedChanged method

        /****************************************
         * Event Handlers for Accessories panel *
         ****************************************/
        private void checkBox_accessories_rearRack_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_accessories_rearRack.Checked) {
                accessoriesTotal += 425.00;
            } else {
                accessoriesTotal -= 425.00;
            }// end of if..else
        }// end of checkBox_accessories_rearRack_CheckedChanged method

        private void checkBox_accessories_roofSpoiler_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_accessories_roofSpoiler.Checked) {
                accessoriesTotal += 375.00;
            } else {
                accessoriesTotal -= 375.00;
            }// end of if..else
        }// end of checkBox_accessories_roofSpoiler_CheckedChanged method

        private void checkBox_accessories_sportExhaust_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_accessories_sportExhaust.Checked) {
                accessoriesTotal += 1130.00;
            } else {
                accessoriesTotal -= 1130.00;
            }// end of if..else
        }// end of checkBox_accessories_sportExhaust_CheckedChanged method

        private void checkBox_accessories_rearApron_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_accessories_rearApron.Checked) {
                accessoriesTotal += 565.00;
            } else {
                accessoriesTotal -= 565.00;
            }// end of if..else
        }// end of checkBox_accessories_rearApron_CheckedChanged method

        private void checkBox_accessories_frontSpoiler_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_accessories_frontSpoiler.Checked) {
                accessoriesTotal += 470.00;
            } else {
                accessoriesTotal -= 470.00;
            }// end of if..else
        }// end of checkBox_accessories_frontSpoiler_CheckedChanged method

        private void checkBox_accessories_chromePackage_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_accessories_chromePackage.Checked) {
                accessoriesTotal += 435.00;
            } else {
                accessoriesTotal -= 435.00;
            }// end of if..else
        }// end of checkBox_accessories_chromePackage_CheckedChanged method

        private void checkBox_accessories_sideSkirts_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_accessories_sideSkirts.Checked) {
                accessoriesTotal += 750.00;
            } else {
                accessoriesTotal -= 750.00;
            }// end of if..else
        }// end of checkBox_accessories_sideSkirts_CheckedChanged method

    }// end of Form_MainWindow Class

}// end of assignment2_michealWalls namespace