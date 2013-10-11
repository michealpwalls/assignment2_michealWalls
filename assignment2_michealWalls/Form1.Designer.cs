/*
 *      Form1.Designer.cs    - v0.1
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

namespace assignment2_michealWalls
{
    partial class Form_MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainWindow));
            this.textBox_additionalOptions = new System.Windows.Forms.TextBox();
            this.textBox_subTotal = new System.Windows.Forms.TextBox();
            this.textBox_salesTax = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_amountDue = new System.Windows.Forms.TextBox();
            this.label_additionalOptions = new System.Windows.Forms.Label();
            this.label_subTotal = new System.Windows.Forms.Label();
            this.label_salesTax = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_amountDue = new System.Windows.Forms.Label();
            this.tabControl_mainFlowControl = new System.Windows.Forms.TabControl();
            this.tabPage_start = new System.Windows.Forms.TabPage();
            this.button_clearInput1 = new System.Windows.Forms.Button();
            this.label_basePrice_gas = new System.Windows.Forms.Label();
            this.label_basePrice_electric = new System.Windows.Forms.Label();
            this.label_basePrice_two = new System.Windows.Forms.Label();
            this.label_basePrice_new = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_tabControl_next1 = new System.Windows.Forms.Button();
            this.label_tradeInAllowance = new System.Windows.Forms.Label();
            this.label_basePrice = new System.Windows.Forms.Label();
            this.textBox_tradeInAllowance = new System.Windows.Forms.TextBox();
            this.textBox_basePrice = new System.Windows.Forms.TextBox();
            this.tabPage_appearance = new System.Windows.Forms.TabPage();
            this.groupBox_appearance_packages = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_appearance_packages_pureStyle = new System.Windows.Forms.Label();
            this.radioButton_appearance_packages_pureStyle = new System.Windows.Forms.RadioButton();
            this.radioButton_appearance_packages_none = new System.Windows.Forms.RadioButton();
            this.button_tabControl_next2 = new System.Windows.Forms.Button();
            this.button_tabControl_back1 = new System.Windows.Forms.Button();
            this.tabPage_accessories = new System.Windows.Forms.TabPage();
            this.label_accessories_sideSkirts_price = new System.Windows.Forms.Label();
            this.label_accessories_chromePackage_price = new System.Windows.Forms.Label();
            this.label_accessories_chromePackage_description = new System.Windows.Forms.Label();
            this.label_accessories_frontSpoiler_price = new System.Windows.Forms.Label();
            this.label_accessories_rearApron_price = new System.Windows.Forms.Label();
            this.checkBox_accessories_sideSkirts = new System.Windows.Forms.CheckBox();
            this.checkBox_accessories_chromePackage = new System.Windows.Forms.CheckBox();
            this.checkBox_accessories_frontSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBox_accessories_rearApron = new System.Windows.Forms.CheckBox();
            this.checkBox_accessories_sportExhaust = new System.Windows.Forms.CheckBox();
            this.checkBox_accessories_roofSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBox_accessories_rearRack = new System.Windows.Forms.CheckBox();
            this.label_accessories_sportExhaust_price = new System.Windows.Forms.Label();
            this.label_accessories_roofSpoiler_price = new System.Windows.Forms.Label();
            this.label_accessories_rackPrice = new System.Windows.Forms.Label();
            this.button_tabControl_next3 = new System.Windows.Forms.Button();
            this.button_tabControl_back2 = new System.Windows.Forms.Button();
            this.tabPage_options = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_options_surroundSystem_description = new System.Windows.Forms.Label();
            this.label_options_iPod_price = new System.Windows.Forms.Label();
            this.label_options_heatedSeats_price = new System.Windows.Forms.Label();
            this.label_options_runningLights_price = new System.Windows.Forms.Label();
            this.label_options_surroundSystem_price = new System.Windows.Forms.Label();
            this.label_options_touchScreen_price = new System.Windows.Forms.Label();
            this.label_options_bluetoothPackage_description = new System.Windows.Forms.Label();
            this.checkBox_options_iPod = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_options_heatedSeats = new System.Windows.Forms.CheckBox();
            this.checkBox_options_runningLights = new System.Windows.Forms.CheckBox();
            this.checkBox_options_surroundSystem = new System.Windows.Forms.CheckBox();
            this.checkBox_options_touchScreen = new System.Windows.Forms.CheckBox();
            this.checkBox_options_bluetoothPackage = new System.Windows.Forms.CheckBox();
            this.label_options_price_centreConsole = new System.Windows.Forms.Label();
            this.checkBox_options_centreConsole = new System.Windows.Forms.CheckBox();
            this.button_tabControl_next4 = new System.Windows.Forms.Button();
            this.button_tabControl_back3 = new System.Windows.Forms.Button();
            this.tabPage_totals = new System.Windows.Forms.TabPage();
            this.pictureBox_total = new System.Windows.Forms.PictureBox();
            this.button_clearInput2 = new System.Windows.Forms.Button();
            this.button_tabControl_back4 = new System.Windows.Forms.Button();
            this.stripMenu = new System.Windows.Forms.MenuStrip();
            this.stripMenu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_edit_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_edit_calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_edit_colour = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_edit_font = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_appTitle = new System.Windows.Forms.Label();
            this.label_appTagline = new System.Windows.Forms.Label();
            this.tabControl_mainFlowControl.SuspendLayout();
            this.tabPage_start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage_appearance.SuspendLayout();
            this.groupBox_appearance_packages.SuspendLayout();
            this.tabPage_accessories.SuspendLayout();
            this.tabPage_options.SuspendLayout();
            this.tabPage_totals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_total)).BeginInit();
            this.stripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_additionalOptions
            // 
            this.textBox_additionalOptions.Location = new System.Drawing.Point(153, 127);
            this.textBox_additionalOptions.Name = "textBox_additionalOptions";
            this.textBox_additionalOptions.ReadOnly = true;
            this.textBox_additionalOptions.Size = new System.Drawing.Size(100, 20);
            this.textBox_additionalOptions.TabIndex = 4;
            this.textBox_additionalOptions.TabStop = false;
            this.textBox_additionalOptions.Text = "$0";
            // 
            // textBox_subTotal
            // 
            this.textBox_subTotal.Location = new System.Drawing.Point(153, 154);
            this.textBox_subTotal.Name = "textBox_subTotal";
            this.textBox_subTotal.ReadOnly = true;
            this.textBox_subTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_subTotal.TabIndex = 5;
            this.textBox_subTotal.TabStop = false;
            this.textBox_subTotal.Text = "$0";
            // 
            // textBox_salesTax
            // 
            this.textBox_salesTax.Location = new System.Drawing.Point(153, 181);
            this.textBox_salesTax.Name = "textBox_salesTax";
            this.textBox_salesTax.ReadOnly = true;
            this.textBox_salesTax.Size = new System.Drawing.Size(100, 20);
            this.textBox_salesTax.TabIndex = 6;
            this.textBox_salesTax.TabStop = false;
            this.textBox_salesTax.Text = "$0";
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(153, 208);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(100, 20);
            this.textBox_total.TabIndex = 7;
            this.textBox_total.TabStop = false;
            this.textBox_total.Text = "$0";
            // 
            // textBox_amountDue
            // 
            this.textBox_amountDue.Location = new System.Drawing.Point(153, 235);
            this.textBox_amountDue.Name = "textBox_amountDue";
            this.textBox_amountDue.Size = new System.Drawing.Size(100, 20);
            this.textBox_amountDue.TabIndex = 8;
            this.textBox_amountDue.TabStop = false;
            this.textBox_amountDue.Text = "$0";
            // 
            // label_additionalOptions
            // 
            this.label_additionalOptions.AutoSize = true;
            this.label_additionalOptions.Location = new System.Drawing.Point(48, 130);
            this.label_additionalOptions.Name = "label_additionalOptions";
            this.label_additionalOptions.Size = new System.Drawing.Size(92, 13);
            this.label_additionalOptions.TabIndex = 9;
            this.label_additionalOptions.Text = "Additional Options";
            // 
            // label_subTotal
            // 
            this.label_subTotal.AutoSize = true;
            this.label_subTotal.Location = new System.Drawing.Point(48, 157);
            this.label_subTotal.Name = "label_subTotal";
            this.label_subTotal.Size = new System.Drawing.Size(50, 13);
            this.label_subTotal.TabIndex = 10;
            this.label_subTotal.Text = "SubTotal";
            // 
            // label_salesTax
            // 
            this.label_salesTax.AutoSize = true;
            this.label_salesTax.Location = new System.Drawing.Point(48, 184);
            this.label_salesTax.Name = "label_salesTax";
            this.label_salesTax.Size = new System.Drawing.Size(54, 13);
            this.label_salesTax.TabIndex = 11;
            this.label_salesTax.Text = "Sales Tax";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(48, 211);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(31, 13);
            this.label_total.TabIndex = 12;
            this.label_total.Text = "Total";
            // 
            // label_amountDue
            // 
            this.label_amountDue.AutoSize = true;
            this.label_amountDue.Location = new System.Drawing.Point(48, 238);
            this.label_amountDue.Name = "label_amountDue";
            this.label_amountDue.Size = new System.Drawing.Size(66, 13);
            this.label_amountDue.TabIndex = 13;
            this.label_amountDue.Text = "Amount Due";
            // 
            // tabControl_mainFlowControl
            // 
            this.tabControl_mainFlowControl.Controls.Add(this.tabPage_start);
            this.tabControl_mainFlowControl.Controls.Add(this.tabPage_appearance);
            this.tabControl_mainFlowControl.Controls.Add(this.tabPage_accessories);
            this.tabControl_mainFlowControl.Controls.Add(this.tabPage_options);
            this.tabControl_mainFlowControl.Controls.Add(this.tabPage_totals);
            this.tabControl_mainFlowControl.Location = new System.Drawing.Point(5, 94);
            this.tabControl_mainFlowControl.Name = "tabControl_mainFlowControl";
            this.tabControl_mainFlowControl.SelectedIndex = 0;
            this.tabControl_mainFlowControl.Size = new System.Drawing.Size(295, 344);
            this.tabControl_mainFlowControl.TabIndex = 300;
            this.tabControl_mainFlowControl.TabStop = false;
            this.tabControl_mainFlowControl.SelectedIndexChanged += new System.EventHandler(this.tabPage_totals_OnFocus);
            // 
            // tabPage_start
            // 
            this.tabPage_start.Controls.Add(this.button_clearInput1);
            this.tabPage_start.Controls.Add(this.label_basePrice_gas);
            this.tabPage_start.Controls.Add(this.label_basePrice_electric);
            this.tabPage_start.Controls.Add(this.label_basePrice_two);
            this.tabPage_start.Controls.Add(this.label_basePrice_new);
            this.tabPage_start.Controls.Add(this.pictureBox3);
            this.tabPage_start.Controls.Add(this.pictureBox2);
            this.tabPage_start.Controls.Add(this.button_tabControl_next1);
            this.tabPage_start.Controls.Add(this.label_tradeInAllowance);
            this.tabPage_start.Controls.Add(this.label_basePrice);
            this.tabPage_start.Controls.Add(this.textBox_tradeInAllowance);
            this.tabPage_start.Controls.Add(this.textBox_basePrice);
            this.tabPage_start.Location = new System.Drawing.Point(4, 22);
            this.tabPage_start.Name = "tabPage_start";
            this.tabPage_start.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_start.Size = new System.Drawing.Size(287, 318);
            this.tabPage_start.TabIndex = 5;
            this.tabPage_start.Text = "Base Line";
            this.tabPage_start.UseVisualStyleBackColor = true;
            // 
            // button_clearInput1
            // 
            this.button_clearInput1.Location = new System.Drawing.Point(66, 289);
            this.button_clearInput1.Name = "button_clearInput1";
            this.button_clearInput1.Size = new System.Drawing.Size(75, 23);
            this.button_clearInput1.TabIndex = 3;
            this.button_clearInput1.Text = "Clear";
            this.button_clearInput1.UseVisualStyleBackColor = true;
            this.button_clearInput1.Click += new System.EventHandler(this.clearInputFields);
            // 
            // label_basePrice_gas
            // 
            this.label_basePrice_gas.AutoSize = true;
            this.label_basePrice_gas.Location = new System.Drawing.Point(200, 134);
            this.label_basePrice_gas.Name = "label_basePrice_gas";
            this.label_basePrice_gas.Size = new System.Drawing.Size(26, 13);
            this.label_basePrice_gas.TabIndex = 10;
            this.label_basePrice_gas.Text = "Gas";
            // 
            // label_basePrice_electric
            // 
            this.label_basePrice_electric.AutoSize = true;
            this.label_basePrice_electric.Location = new System.Drawing.Point(48, 134);
            this.label_basePrice_electric.Name = "label_basePrice_electric";
            this.label_basePrice_electric.Size = new System.Drawing.Size(42, 13);
            this.label_basePrice_electric.TabIndex = 9;
            this.label_basePrice_electric.Text = "Electric";
            // 
            // label_basePrice_two
            // 
            this.label_basePrice_two.AutoSize = true;
            this.label_basePrice_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_basePrice_two.Location = new System.Drawing.Point(177, 152);
            this.label_basePrice_two.Name = "label_basePrice_two";
            this.label_basePrice_two.Size = new System.Drawing.Size(71, 13);
            this.label_basePrice_two.TabIndex = 8;
            this.label_basePrice_two.Text = "$14,000.00";
            // 
            // label_basePrice_new
            // 
            this.label_basePrice_new.AutoSize = true;
            this.label_basePrice_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_basePrice_new.Location = new System.Drawing.Point(36, 152);
            this.label_basePrice_new.Name = "label_basePrice_new";
            this.label_basePrice_new.Size = new System.Drawing.Size(71, 13);
            this.label_basePrice_new.TabIndex = 7;
            this.label_basePrice_new.Text = "$25,000.00";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(166, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_tabControl_next1
            // 
            this.button_tabControl_next1.Location = new System.Drawing.Point(147, 289);
            this.button_tabControl_next1.Name = "button_tabControl_next1";
            this.button_tabControl_next1.Size = new System.Drawing.Size(75, 23);
            this.button_tabControl_next1.TabIndex = 2;
            this.button_tabControl_next1.Text = "Next";
            this.button_tabControl_next1.UseVisualStyleBackColor = true;
            this.button_tabControl_next1.Click += new System.EventHandler(this.button_tabControl_next1_Click);
            // 
            // label_tradeInAllowance
            // 
            this.label_tradeInAllowance.AutoSize = true;
            this.label_tradeInAllowance.Location = new System.Drawing.Point(35, 244);
            this.label_tradeInAllowance.Name = "label_tradeInAllowance";
            this.label_tradeInAllowance.Size = new System.Drawing.Size(99, 13);
            this.label_tradeInAllowance.TabIndex = 3;
            this.label_tradeInAllowance.Text = "Trade In Allowance";
            // 
            // label_basePrice
            // 
            this.label_basePrice.AutoSize = true;
            this.label_basePrice.Location = new System.Drawing.Point(35, 217);
            this.label_basePrice.Name = "label_basePrice";
            this.label_basePrice.Size = new System.Drawing.Size(58, 13);
            this.label_basePrice.TabIndex = 2;
            this.label_basePrice.Text = "Base Price";
            // 
            // textBox_tradeInAllowance
            // 
            this.textBox_tradeInAllowance.Location = new System.Drawing.Point(147, 241);
            this.textBox_tradeInAllowance.Name = "textBox_tradeInAllowance";
            this.textBox_tradeInAllowance.Size = new System.Drawing.Size(100, 20);
            this.textBox_tradeInAllowance.TabIndex = 1;
            this.textBox_tradeInAllowance.Text = "$0";
            // 
            // textBox_basePrice
            // 
            this.textBox_basePrice.Location = new System.Drawing.Point(147, 214);
            this.textBox_basePrice.Name = "textBox_basePrice";
            this.textBox_basePrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_basePrice.TabIndex = 0;
            this.textBox_basePrice.Text = "$0";
            // 
            // tabPage_appearance
            // 
            this.tabPage_appearance.Controls.Add(this.groupBox_appearance_packages);
            this.tabPage_appearance.Controls.Add(this.button_tabControl_next2);
            this.tabPage_appearance.Controls.Add(this.button_tabControl_back1);
            this.tabPage_appearance.Location = new System.Drawing.Point(4, 22);
            this.tabPage_appearance.Name = "tabPage_appearance";
            this.tabPage_appearance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_appearance.Size = new System.Drawing.Size(287, 318);
            this.tabPage_appearance.TabIndex = 1;
            this.tabPage_appearance.Text = "Appearance";
            this.tabPage_appearance.UseVisualStyleBackColor = true;
            // 
            // groupBox_appearance_packages
            // 
            this.groupBox_appearance_packages.Controls.Add(this.label3);
            this.groupBox_appearance_packages.Controls.Add(this.label2);
            this.groupBox_appearance_packages.Controls.Add(this.label1);
            this.groupBox_appearance_packages.Controls.Add(this.label_appearance_packages_pureStyle);
            this.groupBox_appearance_packages.Controls.Add(this.radioButton_appearance_packages_pureStyle);
            this.groupBox_appearance_packages.Controls.Add(this.radioButton_appearance_packages_none);
            this.groupBox_appearance_packages.Location = new System.Drawing.Point(7, 6);
            this.groupBox_appearance_packages.Name = "groupBox_appearance_packages";
            this.groupBox_appearance_packages.Size = new System.Drawing.Size(274, 108);
            this.groupBox_appearance_packages.TabIndex = 2;
            this.groupBox_appearance_packages.TabStop = false;
            this.groupBox_appearance_packages.Text = "Packages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base model with no additional styling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "$0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "double 3-spoke alloy wheels, Fog Lamps";
            // 
            // label_appearance_packages_pureStyle
            // 
            this.label_appearance_packages_pureStyle.AutoSize = true;
            this.label_appearance_packages_pureStyle.Location = new System.Drawing.Point(243, 65);
            this.label_appearance_packages_pureStyle.Name = "label_appearance_packages_pureStyle";
            this.label_appearance_packages_pureStyle.Size = new System.Drawing.Size(31, 13);
            this.label_appearance_packages_pureStyle.TabIndex = 2;
            this.label_appearance_packages_pureStyle.Text = "$800";
            // 
            // radioButton_appearance_packages_pureStyle
            // 
            this.radioButton_appearance_packages_pureStyle.AutoSize = true;
            this.radioButton_appearance_packages_pureStyle.Location = new System.Drawing.Point(7, 61);
            this.radioButton_appearance_packages_pureStyle.Name = "radioButton_appearance_packages_pureStyle";
            this.radioButton_appearance_packages_pureStyle.Size = new System.Drawing.Size(129, 17);
            this.radioButton_appearance_packages_pureStyle.TabIndex = 1;
            this.radioButton_appearance_packages_pureStyle.Text = "\"Pure\" Style Package";
            this.radioButton_appearance_packages_pureStyle.UseVisualStyleBackColor = true;
            this.radioButton_appearance_packages_pureStyle.Click += new System.EventHandler(this.radioButton_appearance_packages_pureStyle_Click);
            // 
            // radioButton_appearance_packages_none
            // 
            this.radioButton_appearance_packages_none.AutoSize = true;
            this.radioButton_appearance_packages_none.Checked = true;
            this.radioButton_appearance_packages_none.Location = new System.Drawing.Point(7, 20);
            this.radioButton_appearance_packages_none.Name = "radioButton_appearance_packages_none";
            this.radioButton_appearance_packages_none.Size = new System.Drawing.Size(51, 17);
            this.radioButton_appearance_packages_none.TabIndex = 0;
            this.radioButton_appearance_packages_none.TabStop = true;
            this.radioButton_appearance_packages_none.Text = "None";
            this.radioButton_appearance_packages_none.UseVisualStyleBackColor = true;
            this.radioButton_appearance_packages_none.Click += new System.EventHandler(this.radioButton_appearance_packages_none_Click);
            // 
            // button_tabControl_next2
            // 
            this.button_tabControl_next2.Location = new System.Drawing.Point(206, 289);
            this.button_tabControl_next2.Name = "button_tabControl_next2";
            this.button_tabControl_next2.Size = new System.Drawing.Size(75, 23);
            this.button_tabControl_next2.TabIndex = 2;
            this.button_tabControl_next2.Text = "Next";
            this.button_tabControl_next2.UseVisualStyleBackColor = true;
            this.button_tabControl_next2.Click += new System.EventHandler(this.button_tabControl_next2_Click);
            // 
            // button_tabControl_back1
            // 
            this.button_tabControl_back1.Location = new System.Drawing.Point(7, 289);
            this.button_tabControl_back1.Name = "button_tabControl_back1";
            this.button_tabControl_back1.Size = new System.Drawing.Size(75, 23);
            this.button_tabControl_back1.TabIndex = 3;
            this.button_tabControl_back1.Text = "Back";
            this.button_tabControl_back1.UseVisualStyleBackColor = true;
            this.button_tabControl_back1.Click += new System.EventHandler(this.button_tabControl_back1_Click);
            // 
            // tabPage_accessories
            // 
            this.tabPage_accessories.Controls.Add(this.label_accessories_sideSkirts_price);
            this.tabPage_accessories.Controls.Add(this.label_accessories_chromePackage_price);
            this.tabPage_accessories.Controls.Add(this.label_accessories_chromePackage_description);
            this.tabPage_accessories.Controls.Add(this.label_accessories_frontSpoiler_price);
            this.tabPage_accessories.Controls.Add(this.label_accessories_rearApron_price);
            this.tabPage_accessories.Controls.Add(this.checkBox_accessories_sideSkirts);
            this.tabPage_accessories.Controls.Add(this.checkBox_accessories_chromePackage);
            this.tabPage_accessories.Controls.Add(this.checkBox_accessories_frontSpoiler);
            this.tabPage_accessories.Controls.Add(this.checkBox_accessories_rearApron);
            this.tabPage_accessories.Controls.Add(this.checkBox_accessories_sportExhaust);
            this.tabPage_accessories.Controls.Add(this.checkBox_accessories_roofSpoiler);
            this.tabPage_accessories.Controls.Add(this.checkBox_accessories_rearRack);
            this.tabPage_accessories.Controls.Add(this.label_accessories_sportExhaust_price);
            this.tabPage_accessories.Controls.Add(this.label_accessories_roofSpoiler_price);
            this.tabPage_accessories.Controls.Add(this.label_accessories_rackPrice);
            this.tabPage_accessories.Controls.Add(this.button_tabControl_next3);
            this.tabPage_accessories.Controls.Add(this.button_tabControl_back2);
            this.tabPage_accessories.Location = new System.Drawing.Point(4, 22);
            this.tabPage_accessories.Name = "tabPage_accessories";
            this.tabPage_accessories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_accessories.Size = new System.Drawing.Size(287, 318);
            this.tabPage_accessories.TabIndex = 2;
            this.tabPage_accessories.Text = "Accessories";
            this.tabPage_accessories.UseVisualStyleBackColor = true;
            // 
            // label_accessories_sideSkirts_price
            // 
            this.label_accessories_sideSkirts_price.AutoSize = true;
            this.label_accessories_sideSkirts_price.Location = new System.Drawing.Point(240, 215);
            this.label_accessories_sideSkirts_price.Name = "label_accessories_sideSkirts_price";
            this.label_accessories_sideSkirts_price.Size = new System.Drawing.Size(46, 13);
            this.label_accessories_sideSkirts_price.TabIndex = 21;
            this.label_accessories_sideSkirts_price.Text = "$750.00";
            // 
            // label_accessories_chromePackage_price
            // 
            this.label_accessories_chromePackage_price.AutoSize = true;
            this.label_accessories_chromePackage_price.Location = new System.Drawing.Point(240, 168);
            this.label_accessories_chromePackage_price.Name = "label_accessories_chromePackage_price";
            this.label_accessories_chromePackage_price.Size = new System.Drawing.Size(46, 13);
            this.label_accessories_chromePackage_price.TabIndex = 20;
            this.label_accessories_chromePackage_price.Text = "$435.00";
            // 
            // label_accessories_chromePackage_description
            // 
            this.label_accessories_chromePackage_description.AutoSize = true;
            this.label_accessories_chromePackage_description.Location = new System.Drawing.Point(36, 188);
            this.label_accessories_chromePackage_description.Name = "label_accessories_chromePackage_description";
            this.label_accessories_chromePackage_description.Size = new System.Drawing.Size(226, 13);
            this.label_accessories_chromePackage_description.TabIndex = 19;
            this.label_accessories_chromePackage_description.Text = "Mirror Caps, Radiator Grille and Rear Trim Strip";
            // 
            // label_accessories_frontSpoiler_price
            // 
            this.label_accessories_frontSpoiler_price.AutoSize = true;
            this.label_accessories_frontSpoiler_price.Location = new System.Drawing.Point(241, 132);
            this.label_accessories_frontSpoiler_price.Name = "label_accessories_frontSpoiler_price";
            this.label_accessories_frontSpoiler_price.Size = new System.Drawing.Size(46, 13);
            this.label_accessories_frontSpoiler_price.TabIndex = 18;
            this.label_accessories_frontSpoiler_price.Text = "$470.00";
            // 
            // label_accessories_rearApron_price
            // 
            this.label_accessories_rearApron_price.AutoSize = true;
            this.label_accessories_rearApron_price.Location = new System.Drawing.Point(241, 101);
            this.label_accessories_rearApron_price.Name = "label_accessories_rearApron_price";
            this.label_accessories_rearApron_price.Size = new System.Drawing.Size(46, 13);
            this.label_accessories_rearApron_price.TabIndex = 17;
            this.label_accessories_rearApron_price.Text = "$565.00";
            // 
            // checkBox_accessories_sideSkirts
            // 
            this.checkBox_accessories_sideSkirts.AutoSize = true;
            this.checkBox_accessories_sideSkirts.Location = new System.Drawing.Point(7, 214);
            this.checkBox_accessories_sideSkirts.Name = "checkBox_accessories_sideSkirts";
            this.checkBox_accessories_sideSkirts.Size = new System.Drawing.Size(123, 17);
            this.checkBox_accessories_sideSkirts.TabIndex = 6;
            this.checkBox_accessories_sideSkirts.Text = "BARBUS Side Skirts";
            this.checkBox_accessories_sideSkirts.UseVisualStyleBackColor = true;
            this.checkBox_accessories_sideSkirts.CheckedChanged += new System.EventHandler(this.checkBox_accessories_sideSkirts_CheckedChanged);
            // 
            // checkBox_accessories_chromePackage
            // 
            this.checkBox_accessories_chromePackage.AutoSize = true;
            this.checkBox_accessories_chromePackage.Location = new System.Drawing.Point(7, 168);
            this.checkBox_accessories_chromePackage.Name = "checkBox_accessories_chromePackage";
            this.checkBox_accessories_chromePackage.Size = new System.Drawing.Size(108, 17);
            this.checkBox_accessories_chromePackage.TabIndex = 5;
            this.checkBox_accessories_chromePackage.Text = "Chrome Package";
            this.checkBox_accessories_chromePackage.UseVisualStyleBackColor = true;
            this.checkBox_accessories_chromePackage.CheckedChanged += new System.EventHandler(this.checkBox_accessories_chromePackage_CheckedChanged);
            // 
            // checkBox_accessories_frontSpoiler
            // 
            this.checkBox_accessories_frontSpoiler.AutoSize = true;
            this.checkBox_accessories_frontSpoiler.Location = new System.Drawing.Point(7, 132);
            this.checkBox_accessories_frontSpoiler.Name = "checkBox_accessories_frontSpoiler";
            this.checkBox_accessories_frontSpoiler.Size = new System.Drawing.Size(132, 17);
            this.checkBox_accessories_frontSpoiler.TabIndex = 4;
            this.checkBox_accessories_frontSpoiler.Text = "BARBUS Front Spoiler";
            this.checkBox_accessories_frontSpoiler.UseVisualStyleBackColor = true;
            this.checkBox_accessories_frontSpoiler.CheckedChanged += new System.EventHandler(this.checkBox_accessories_frontSpoiler_CheckedChanged);
            // 
            // checkBox_accessories_rearApron
            // 
            this.checkBox_accessories_rearApron.AutoSize = true;
            this.checkBox_accessories_rearApron.Location = new System.Drawing.Point(6, 101);
            this.checkBox_accessories_rearApron.Name = "checkBox_accessories_rearApron";
            this.checkBox_accessories_rearApron.Size = new System.Drawing.Size(227, 17);
            this.checkBox_accessories_rearApron.TabIndex = 3;
            this.checkBox_accessories_rearApron.Text = "BARBUS Apron for Sports Exhaust System";
            this.checkBox_accessories_rearApron.UseVisualStyleBackColor = true;
            this.checkBox_accessories_rearApron.CheckedChanged += new System.EventHandler(this.checkBox_accessories_rearApron_CheckedChanged);
            // 
            // checkBox_accessories_sportExhaust
            // 
            this.checkBox_accessories_sportExhaust.AutoSize = true;
            this.checkBox_accessories_sportExhaust.Location = new System.Drawing.Point(8, 71);
            this.checkBox_accessories_sportExhaust.Name = "checkBox_accessories_sportExhaust";
            this.checkBox_accessories_sportExhaust.Size = new System.Drawing.Size(181, 17);
            this.checkBox_accessories_sportExhaust.TabIndex = 2;
            this.checkBox_accessories_sportExhaust.Text = "BARBUS Sports Exhaust System";
            this.checkBox_accessories_sportExhaust.UseVisualStyleBackColor = true;
            this.checkBox_accessories_sportExhaust.CheckedChanged += new System.EventHandler(this.checkBox_accessories_sportExhaust_CheckedChanged);
            // 
            // checkBox_accessories_roofSpoiler
            // 
            this.checkBox_accessories_roofSpoiler.AutoSize = true;
            this.checkBox_accessories_roofSpoiler.Location = new System.Drawing.Point(8, 39);
            this.checkBox_accessories_roofSpoiler.Name = "checkBox_accessories_roofSpoiler";
            this.checkBox_accessories_roofSpoiler.Size = new System.Drawing.Size(131, 17);
            this.checkBox_accessories_roofSpoiler.TabIndex = 1;
            this.checkBox_accessories_roofSpoiler.Text = "BARBUS Roof Spoiler";
            this.checkBox_accessories_roofSpoiler.UseVisualStyleBackColor = true;
            this.checkBox_accessories_roofSpoiler.CheckedChanged += new System.EventHandler(this.checkBox_accessories_roofSpoiler_CheckedChanged);
            // 
            // checkBox_accessories_rearRack
            // 
            this.checkBox_accessories_rearRack.AutoSize = true;
            this.checkBox_accessories_rearRack.Location = new System.Drawing.Point(7, 7);
            this.checkBox_accessories_rearRack.Name = "checkBox_accessories_rearRack";
            this.checkBox_accessories_rearRack.Size = new System.Drawing.Size(159, 17);
            this.checkBox_accessories_rearRack.TabIndex = 0;
            this.checkBox_accessories_rearRack.Text = "Rear-mounted Rack System";
            this.checkBox_accessories_rearRack.UseVisualStyleBackColor = true;
            this.checkBox_accessories_rearRack.CheckedChanged += new System.EventHandler(this.checkBox_accessories_rearRack_CheckedChanged);
            // 
            // label_accessories_sportExhaust_price
            // 
            this.label_accessories_sportExhaust_price.AutoSize = true;
            this.label_accessories_sportExhaust_price.Location = new System.Drawing.Point(232, 72);
            this.label_accessories_sportExhaust_price.Name = "label_accessories_sportExhaust_price";
            this.label_accessories_sportExhaust_price.Size = new System.Drawing.Size(55, 13);
            this.label_accessories_sportExhaust_price.TabIndex = 9;
            this.label_accessories_sportExhaust_price.Text = "$1,130.00";
            // 
            // label_accessories_roofSpoiler_price
            // 
            this.label_accessories_roofSpoiler_price.AutoSize = true;
            this.label_accessories_roofSpoiler_price.Location = new System.Drawing.Point(240, 39);
            this.label_accessories_roofSpoiler_price.Name = "label_accessories_roofSpoiler_price";
            this.label_accessories_roofSpoiler_price.Size = new System.Drawing.Size(46, 13);
            this.label_accessories_roofSpoiler_price.TabIndex = 8;
            this.label_accessories_roofSpoiler_price.Text = "$375.00";
            // 
            // label_accessories_rackPrice
            // 
            this.label_accessories_rackPrice.AutoSize = true;
            this.label_accessories_rackPrice.Location = new System.Drawing.Point(240, 7);
            this.label_accessories_rackPrice.Name = "label_accessories_rackPrice";
            this.label_accessories_rackPrice.Size = new System.Drawing.Size(46, 13);
            this.label_accessories_rackPrice.TabIndex = 7;
            this.label_accessories_rackPrice.Text = "$425.00";
            // 
            // button_tabControl_next3
            // 
            this.button_tabControl_next3.Location = new System.Drawing.Point(206, 289);
            this.button_tabControl_next3.Name = "button_tabControl_next3";
            this.button_tabControl_next3.Size = new System.Drawing.Size(75, 23);
            this.button_tabControl_next3.TabIndex = 7;
            this.button_tabControl_next3.Text = "Next";
            this.button_tabControl_next3.UseVisualStyleBackColor = true;
            this.button_tabControl_next3.Click += new System.EventHandler(this.button_tabControl_next3_Click);
            // 
            // button_tabControl_back2
            // 
            this.button_tabControl_back2.Location = new System.Drawing.Point(7, 289);
            this.button_tabControl_back2.Name = "button_tabControl_back2";
            this.button_tabControl_back2.Size = new System.Drawing.Size(75, 23);
            this.button_tabControl_back2.TabIndex = 8;
            this.button_tabControl_back2.Text = "Back";
            this.button_tabControl_back2.UseVisualStyleBackColor = true;
            this.button_tabControl_back2.Click += new System.EventHandler(this.button_tabControl_back2_Click);
            // 
            // tabPage_options
            // 
            this.tabPage_options.Controls.Add(this.label9);
            this.tabPage_options.Controls.Add(this.label5);
            this.tabPage_options.Controls.Add(this.label_options_surroundSystem_description);
            this.tabPage_options.Controls.Add(this.label_options_iPod_price);
            this.tabPage_options.Controls.Add(this.label_options_heatedSeats_price);
            this.tabPage_options.Controls.Add(this.label_options_runningLights_price);
            this.tabPage_options.Controls.Add(this.label_options_surroundSystem_price);
            this.tabPage_options.Controls.Add(this.label_options_touchScreen_price);
            this.tabPage_options.Controls.Add(this.label_options_bluetoothPackage_description);
            this.tabPage_options.Controls.Add(this.checkBox_options_iPod);
            this.tabPage_options.Controls.Add(this.label4);
            this.tabPage_options.Controls.Add(this.checkBox_options_heatedSeats);
            this.tabPage_options.Controls.Add(this.checkBox_options_runningLights);
            this.tabPage_options.Controls.Add(this.checkBox_options_surroundSystem);
            this.tabPage_options.Controls.Add(this.checkBox_options_touchScreen);
            this.tabPage_options.Controls.Add(this.checkBox_options_bluetoothPackage);
            this.tabPage_options.Controls.Add(this.label_options_price_centreConsole);
            this.tabPage_options.Controls.Add(this.checkBox_options_centreConsole);
            this.tabPage_options.Controls.Add(this.button_tabControl_next4);
            this.tabPage_options.Controls.Add(this.button_tabControl_back3);
            this.tabPage_options.Location = new System.Drawing.Point(4, 22);
            this.tabPage_options.Name = "tabPage_options";
            this.tabPage_options.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_options.Size = new System.Drawing.Size(287, 318);
            this.tabPage_options.TabIndex = 3;
            this.tabPage_options.Text = "Options";
            this.tabPage_options.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "subwoofer, 8x40 watt amplifier.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "rear-fill speakers, 2 tweeters in mirror triangles,";
            // 
            // label_options_surroundSystem_description
            // 
            this.label_options_surroundSystem_description.AutoSize = true;
            this.label_options_surroundSystem_description.Location = new System.Drawing.Point(31, 127);
            this.label_options_surroundSystem_description.Name = "label_options_surroundSystem_description";
            this.label_options_surroundSystem_description.Size = new System.Drawing.Size(239, 13);
            this.label_options_surroundSystem_description.TabIndex = 21;
            this.label_options_surroundSystem_description.Text = "2 high performance in-door speakers, 2 additional";
            // 
            // label_options_iPod_price
            // 
            this.label_options_iPod_price.AutoSize = true;
            this.label_options_iPod_price.Location = new System.Drawing.Point(229, 243);
            this.label_options_iPod_price.Name = "label_options_iPod_price";
            this.label_options_iPod_price.Size = new System.Drawing.Size(46, 13);
            this.label_options_iPod_price.TabIndex = 20;
            this.label_options_iPod_price.Text = "$175.00";
            // 
            // label_options_heatedSeats_price
            // 
            this.label_options_heatedSeats_price.AutoSize = true;
            this.label_options_heatedSeats_price.Location = new System.Drawing.Point(229, 216);
            this.label_options_heatedSeats_price.Name = "label_options_heatedSeats_price";
            this.label_options_heatedSeats_price.Size = new System.Drawing.Size(46, 13);
            this.label_options_heatedSeats_price.TabIndex = 19;
            this.label_options_heatedSeats_price.Text = "$340.00";
            // 
            // label_options_runningLights_price
            // 
            this.label_options_runningLights_price.AutoSize = true;
            this.label_options_runningLights_price.Location = new System.Drawing.Point(229, 188);
            this.label_options_runningLights_price.Name = "label_options_runningLights_price";
            this.label_options_runningLights_price.Size = new System.Drawing.Size(46, 13);
            this.label_options_runningLights_price.TabIndex = 18;
            this.label_options_runningLights_price.Text = "$290.00";
            // 
            // label_options_surroundSystem_price
            // 
            this.label_options_surroundSystem_price.AutoSize = true;
            this.label_options_surroundSystem_price.Location = new System.Drawing.Point(235, 107);
            this.label_options_surroundSystem_price.Name = "label_options_surroundSystem_price";
            this.label_options_surroundSystem_price.Size = new System.Drawing.Size(46, 13);
            this.label_options_surroundSystem_price.TabIndex = 17;
            this.label_options_surroundSystem_price.Text = "$590.00";
            // 
            // label_options_touchScreen_price
            // 
            this.label_options_touchScreen_price.AutoSize = true;
            this.label_options_touchScreen_price.Location = new System.Drawing.Point(226, 81);
            this.label_options_touchScreen_price.Name = "label_options_touchScreen_price";
            this.label_options_touchScreen_price.Size = new System.Drawing.Size(55, 13);
            this.label_options_touchScreen_price.TabIndex = 16;
            this.label_options_touchScreen_price.Text = "$1,295.00";
            // 
            // label_options_bluetoothPackage_description
            // 
            this.label_options_bluetoothPackage_description.AutoSize = true;
            this.label_options_bluetoothPackage_description.Location = new System.Drawing.Point(28, 51);
            this.label_options_bluetoothPackage_description.Name = "label_options_bluetoothPackage_description";
            this.label_options_bluetoothPackage_description.Size = new System.Drawing.Size(243, 13);
            this.label_options_bluetoothPackage_description.TabIndex = 15;
            this.label_options_bluetoothPackage_description.Text = "Bluetooth module, cockpit clock and rev. counter.";
            // 
            // checkBox_options_iPod
            // 
            this.checkBox_options_iPod.AutoSize = true;
            this.checkBox_options_iPod.Location = new System.Drawing.Point(7, 243);
            this.checkBox_options_iPod.Name = "checkBox_options_iPod";
            this.checkBox_options_iPod.Size = new System.Drawing.Size(199, 17);
            this.checkBox_options_iPod.TabIndex = 5;
            this.checkBox_options_iPod.Text = "iPod integration for Bluetooth System";
            this.checkBox_options_iPod.UseVisualStyleBackColor = true;
            this.checkBox_options_iPod.CheckedChanged += new System.EventHandler(this.checkBox_options_iPod_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "$450.00";
            // 
            // checkBox_options_heatedSeats
            // 
            this.checkBox_options_heatedSeats.AutoSize = true;
            this.checkBox_options_heatedSeats.Location = new System.Drawing.Point(7, 216);
            this.checkBox_options_heatedSeats.Name = "checkBox_options_heatedSeats";
            this.checkBox_options_heatedSeats.Size = new System.Drawing.Size(91, 17);
            this.checkBox_options_heatedSeats.TabIndex = 5;
            this.checkBox_options_heatedSeats.Text = "Heated Seats";
            this.checkBox_options_heatedSeats.UseVisualStyleBackColor = true;
            this.checkBox_options_heatedSeats.CheckedChanged += new System.EventHandler(this.checkBox_options_heatedSeats_CheckedChanged);
            // 
            // checkBox_options_runningLights
            // 
            this.checkBox_options_runningLights.AutoSize = true;
            this.checkBox_options_runningLights.Location = new System.Drawing.Point(7, 188);
            this.checkBox_options_runningLights.Name = "checkBox_options_runningLights";
            this.checkBox_options_runningLights.Size = new System.Drawing.Size(162, 17);
            this.checkBox_options_runningLights.TabIndex = 4;
            this.checkBox_options_runningLights.Text = "LED Daytime Running Lights";
            this.checkBox_options_runningLights.UseVisualStyleBackColor = true;
            this.checkBox_options_runningLights.CheckedChanged += new System.EventHandler(this.checkBox_options_runningLights_CheckedChanged);
            // 
            // checkBox_options_surroundSystem
            // 
            this.checkBox_options_surroundSystem.AutoSize = true;
            this.checkBox_options_surroundSystem.Location = new System.Drawing.Point(7, 107);
            this.checkBox_options_surroundSystem.Name = "checkBox_options_surroundSystem";
            this.checkBox_options_surroundSystem.Size = new System.Drawing.Size(170, 17);
            this.checkBox_options_surroundSystem.TabIndex = 3;
            this.checkBox_options_surroundSystem.Text = "Smart Surround-Sound System";
            this.checkBox_options_surroundSystem.UseVisualStyleBackColor = true;
            this.checkBox_options_surroundSystem.CheckedChanged += new System.EventHandler(this.checkBox_options_surroundSystem_CheckedChanged);
            // 
            // checkBox_options_touchScreen
            // 
            this.checkBox_options_touchScreen.AutoSize = true;
            this.checkBox_options_touchScreen.Location = new System.Drawing.Point(7, 80);
            this.checkBox_options_touchScreen.Name = "checkBox_options_touchScreen";
            this.checkBox_options_touchScreen.Size = new System.Drawing.Size(179, 17);
            this.checkBox_options_touchScreen.TabIndex = 2;
            this.checkBox_options_touchScreen.Text = "Touchscreen Multimedia System";
            this.checkBox_options_touchScreen.UseVisualStyleBackColor = true;
            this.checkBox_options_touchScreen.CheckedChanged += new System.EventHandler(this.checkBox_options_touchScreen_CheckedChanged);
            // 
            // checkBox_options_bluetoothPackage
            // 
            this.checkBox_options_bluetoothPackage.AutoSize = true;
            this.checkBox_options_bluetoothPackage.Location = new System.Drawing.Point(7, 31);
            this.checkBox_options_bluetoothPackage.Name = "checkBox_options_bluetoothPackage";
            this.checkBox_options_bluetoothPackage.Size = new System.Drawing.Size(117, 17);
            this.checkBox_options_bluetoothPackage.TabIndex = 1;
            this.checkBox_options_bluetoothPackage.Text = "Bluetooth Package";
            this.checkBox_options_bluetoothPackage.UseVisualStyleBackColor = true;
            this.checkBox_options_bluetoothPackage.CheckedChanged += new System.EventHandler(this.checkBox_options_bluetoothPackage_CheckedChanged);
            // 
            // label_options_price_centreConsole
            // 
            this.label_options_price_centreConsole.AutoSize = true;
            this.label_options_price_centreConsole.Location = new System.Drawing.Point(235, 7);
            this.label_options_price_centreConsole.Name = "label_options_price_centreConsole";
            this.label_options_price_centreConsole.Size = new System.Drawing.Size(46, 13);
            this.label_options_price_centreConsole.TabIndex = 7;
            this.label_options_price_centreConsole.Text = "$340.00";
            // 
            // checkBox_options_centreConsole
            // 
            this.checkBox_options_centreConsole.AutoSize = true;
            this.checkBox_options_centreConsole.Location = new System.Drawing.Point(7, 7);
            this.checkBox_options_centreConsole.Name = "checkBox_options_centreConsole";
            this.checkBox_options_centreConsole.Size = new System.Drawing.Size(159, 17);
            this.checkBox_options_centreConsole.TabIndex = 0;
            this.checkBox_options_centreConsole.Text = "Centre Console Storage Box";
            this.checkBox_options_centreConsole.UseVisualStyleBackColor = true;
            this.checkBox_options_centreConsole.CheckedChanged += new System.EventHandler(this.checkBox_options_centreConsole_CheckedChanged);
            // 
            // button_tabControl_next4
            // 
            this.button_tabControl_next4.Location = new System.Drawing.Point(206, 289);
            this.button_tabControl_next4.Name = "button_tabControl_next4";
            this.button_tabControl_next4.Size = new System.Drawing.Size(75, 23);
            this.button_tabControl_next4.TabIndex = 7;
            this.button_tabControl_next4.Text = "Calculate";
            this.button_tabControl_next4.UseVisualStyleBackColor = true;
            this.button_tabControl_next4.Click += new System.EventHandler(this.calculateTotals_sharedHandler);
            // 
            // button_tabControl_back3
            // 
            this.button_tabControl_back3.Location = new System.Drawing.Point(7, 289);
            this.button_tabControl_back3.Name = "button_tabControl_back3";
            this.button_tabControl_back3.Size = new System.Drawing.Size(75, 23);
            this.button_tabControl_back3.TabIndex = 8;
            this.button_tabControl_back3.Text = "Back";
            this.button_tabControl_back3.UseVisualStyleBackColor = true;
            this.button_tabControl_back3.Click += new System.EventHandler(this.button_tabControl_back3_Click);
            // 
            // tabPage_totals
            // 
            this.tabPage_totals.Controls.Add(this.pictureBox_total);
            this.tabPage_totals.Controls.Add(this.button_clearInput2);
            this.tabPage_totals.Controls.Add(this.button_tabControl_back4);
            this.tabPage_totals.Controls.Add(this.textBox_subTotal);
            this.tabPage_totals.Controls.Add(this.label_amountDue);
            this.tabPage_totals.Controls.Add(this.label_total);
            this.tabPage_totals.Controls.Add(this.label_salesTax);
            this.tabPage_totals.Controls.Add(this.label_subTotal);
            this.tabPage_totals.Controls.Add(this.label_additionalOptions);
            this.tabPage_totals.Controls.Add(this.textBox_additionalOptions);
            this.tabPage_totals.Controls.Add(this.textBox_amountDue);
            this.tabPage_totals.Controls.Add(this.textBox_salesTax);
            this.tabPage_totals.Controls.Add(this.textBox_total);
            this.tabPage_totals.Location = new System.Drawing.Point(4, 22);
            this.tabPage_totals.Name = "tabPage_totals";
            this.tabPage_totals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_totals.Size = new System.Drawing.Size(287, 318);
            this.tabPage_totals.TabIndex = 4;
            this.tabPage_totals.Text = "Total";
            this.tabPage_totals.UseVisualStyleBackColor = true;
            // 
            // pictureBox_total
            // 
            this.pictureBox_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_total.Location = new System.Drawing.Point(92, 25);
            this.pictureBox_total.Name = "pictureBox_total";
            this.pictureBox_total.Size = new System.Drawing.Size(100, 67);
            this.pictureBox_total.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_total.TabIndex = 16;
            this.pictureBox_total.TabStop = false;
            // 
            // button_clearInput2
            // 
            this.button_clearInput2.Location = new System.Drawing.Point(62, 289);
            this.button_clearInput2.Name = "button_clearInput2";
            this.button_clearInput2.Size = new System.Drawing.Size(75, 23);
            this.button_clearInput2.TabIndex = 1;
            this.button_clearInput2.Text = "Clear";
            this.button_clearInput2.UseVisualStyleBackColor = true;
            this.button_clearInput2.Click += new System.EventHandler(this.clearInputFields);
            // 
            // button_tabControl_back4
            // 
            this.button_tabControl_back4.Location = new System.Drawing.Point(143, 289);
            this.button_tabControl_back4.Name = "button_tabControl_back4";
            this.button_tabControl_back4.Size = new System.Drawing.Size(75, 23);
            this.button_tabControl_back4.TabIndex = 0;
            this.button_tabControl_back4.Text = "Back";
            this.button_tabControl_back4.UseVisualStyleBackColor = true;
            this.button_tabControl_back4.Click += new System.EventHandler(this.button_tabControl_back4_Click);
            // 
            // stripMenu
            // 
            this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu_file,
            this.stripMenu_edit,
            this.stripMenu_help});
            this.stripMenu.Location = new System.Drawing.Point(0, 0);
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Size = new System.Drawing.Size(304, 24);
            this.stripMenu.TabIndex = 15;
            // 
            // stripMenu_file
            // 
            this.stripMenu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu_file_exit});
            this.stripMenu_file.Name = "stripMenu_file";
            this.stripMenu_file.ShowShortcutKeys = false;
            this.stripMenu_file.Size = new System.Drawing.Size(37, 20);
            this.stripMenu_file.Text = "File";
            // 
            // stripMenu_file_exit
            // 
            this.stripMenu_file_exit.Name = "stripMenu_file_exit";
            this.stripMenu_file_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.stripMenu_file_exit.Size = new System.Drawing.Size(152, 22);
            this.stripMenu_file_exit.Text = "Exit";
            this.stripMenu_file_exit.Click += new System.EventHandler(this.stripMenuItem_fileExit_Click);
            // 
            // stripMenu_edit
            // 
            this.stripMenu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu_edit_clear,
            this.stripMenu_edit_calculate,
            this.stripMenu_edit_colour,
            this.stripMenu_edit_font});
            this.stripMenu_edit.Name = "stripMenu_edit";
            this.stripMenu_edit.ShowShortcutKeys = false;
            this.stripMenu_edit.Size = new System.Drawing.Size(39, 20);
            this.stripMenu_edit.Text = "Edit";
            // 
            // stripMenu_edit_clear
            // 
            this.stripMenu_edit_clear.Name = "stripMenu_edit_clear";
            this.stripMenu_edit_clear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.stripMenu_edit_clear.Size = new System.Drawing.Size(179, 22);
            this.stripMenu_edit_clear.Text = "Clear...";
            this.stripMenu_edit_clear.Click += new System.EventHandler(this.clearInputFields);
            // 
            // stripMenu_edit_calculate
            // 
            this.stripMenu_edit_calculate.Name = "stripMenu_edit_calculate";
            this.stripMenu_edit_calculate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.stripMenu_edit_calculate.Size = new System.Drawing.Size(179, 22);
            this.stripMenu_edit_calculate.Text = "Calculate...";
            this.stripMenu_edit_calculate.Click += new System.EventHandler(this.calculateTotals_sharedHandler);
            // 
            // stripMenu_edit_colour
            // 
            this.stripMenu_edit_colour.Name = "stripMenu_edit_colour";
            this.stripMenu_edit_colour.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.stripMenu_edit_colour.Size = new System.Drawing.Size(179, 22);
            this.stripMenu_edit_colour.Text = "Edit Font Colour";
            this.stripMenu_edit_colour.Click += new System.EventHandler(this.stripMenu_edit_colour_Click);
            // 
            // stripMenu_edit_font
            // 
            this.stripMenu_edit_font.Name = "stripMenu_edit_font";
            this.stripMenu_edit_font.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.stripMenu_edit_font.Size = new System.Drawing.Size(179, 22);
            this.stripMenu_edit_font.Text = "Edit Font Style";
            this.stripMenu_edit_font.Click += new System.EventHandler(this.stripMenu_edit_font_Click);
            // 
            // stripMenu_help
            // 
            this.stripMenu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu_help_about});
            this.stripMenu_help.Name = "stripMenu_help";
            this.stripMenu_help.Size = new System.Drawing.Size(44, 20);
            this.stripMenu_help.Text = "Help";
            // 
            // stripMenu_help_about
            // 
            this.stripMenu_help_about.Name = "stripMenu_help_about";
            this.stripMenu_help_about.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.stripMenu_help_about.Size = new System.Drawing.Size(126, 22);
            this.stripMenu_help_about.Text = "About";
            this.stripMenu_help_about.Click += new System.EventHandler(this.stripMenu_help_about_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // fontDialog
            // 
            this.fontDialog.AllowVerticalFonts = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_appTitle
            // 
            this.label_appTitle.AutoSize = true;
            this.label_appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appTitle.Location = new System.Drawing.Point(112, 28);
            this.label_appTitle.Name = "label_appTitle";
            this.label_appTitle.Size = new System.Drawing.Size(180, 16);
            this.label_appTitle.TabIndex = 18;
            this.label_appTitle.Text = "Koala Korp\'s Auto Centre";
            // 
            // label_appTagline
            // 
            this.label_appTagline.AutoSize = true;
            this.label_appTagline.Location = new System.Drawing.Point(126, 44);
            this.label_appTagline.Name = "label_appTagline";
            this.label_appTagline.Size = new System.Drawing.Size(138, 13);
            this.label_appTagline.TabIndex = 19;
            this.label_appTagline.Text = "Design your own Smart Car!";
            // 
            // Form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.label_appTagline);
            this.Controls.Add(this.label_appTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl_mainFlowControl);
            this.Controls.Add(this.stripMenu);
            this.MainMenuStrip = this.stripMenu;
            this.Name = "Form_MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koala Korp\'s Auto Centre v0.1";
            this.tabControl_mainFlowControl.ResumeLayout(false);
            this.tabPage_start.ResumeLayout(false);
            this.tabPage_start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage_appearance.ResumeLayout(false);
            this.groupBox_appearance_packages.ResumeLayout(false);
            this.groupBox_appearance_packages.PerformLayout();
            this.tabPage_accessories.ResumeLayout(false);
            this.tabPage_accessories.PerformLayout();
            this.tabPage_options.ResumeLayout(false);
            this.tabPage_options.PerformLayout();
            this.tabPage_totals.ResumeLayout(false);
            this.tabPage_totals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_total)).EndInit();
            this.stripMenu.ResumeLayout(false);
            this.stripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_additionalOptions;
        private System.Windows.Forms.TextBox textBox_subTotal;
        private System.Windows.Forms.TextBox textBox_salesTax;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TextBox textBox_amountDue;
        private System.Windows.Forms.Label label_additionalOptions;
        private System.Windows.Forms.Label label_subTotal;
        private System.Windows.Forms.Label label_salesTax;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_amountDue;
        private System.Windows.Forms.TabControl tabControl_mainFlowControl;
        private System.Windows.Forms.TabPage tabPage_appearance;
        private System.Windows.Forms.TabPage tabPage_accessories;
        private System.Windows.Forms.TabPage tabPage_options;
        private System.Windows.Forms.TabPage tabPage_totals;
        private System.Windows.Forms.MenuStrip stripMenu;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_file;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_file_exit;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_edit;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_edit_clear;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_edit_calculate;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_help;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_help_about;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_edit_colour;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_edit_font;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_tabControl_next2;
        private System.Windows.Forms.Button button_tabControl_back1;
        private System.Windows.Forms.Button button_tabControl_next3;
        private System.Windows.Forms.Button button_tabControl_back2;
        private System.Windows.Forms.Button button_tabControl_next4;
        private System.Windows.Forms.Button button_tabControl_back3;
        private System.Windows.Forms.Button button_tabControl_back4;
        private System.Windows.Forms.TabPage tabPage_start;
        private System.Windows.Forms.Button button_tabControl_next1;
        private System.Windows.Forms.Label label_tradeInAllowance;
        private System.Windows.Forms.Label label_basePrice;
        private System.Windows.Forms.TextBox textBox_tradeInAllowance;
        private System.Windows.Forms.TextBox textBox_basePrice;
        private System.Windows.Forms.Label label_basePrice_two;
        private System.Windows.Forms.Label label_basePrice_new;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_basePrice_gas;
        private System.Windows.Forms.Label label_basePrice_electric;
        private System.Windows.Forms.Button button_clearInput1;
        private System.Windows.Forms.Button button_clearInput2;
        private System.Windows.Forms.Label label_appTitle;
        private System.Windows.Forms.Label label_appTagline;
        private System.Windows.Forms.GroupBox groupBox_appearance_packages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_appearance_packages_pureStyle;
        private System.Windows.Forms.RadioButton radioButton_appearance_packages_pureStyle;
        private System.Windows.Forms.RadioButton radioButton_appearance_packages_none;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_options_surroundSystem;
        private System.Windows.Forms.CheckBox checkBox_options_touchScreen;
        private System.Windows.Forms.CheckBox checkBox_options_bluetoothPackage;
        private System.Windows.Forms.Label label_options_price_centreConsole;
        private System.Windows.Forms.CheckBox checkBox_options_centreConsole;
        private System.Windows.Forms.CheckBox checkBox_options_heatedSeats;
        private System.Windows.Forms.CheckBox checkBox_options_runningLights;
        private System.Windows.Forms.Label label_options_bluetoothPackage_description;
        private System.Windows.Forms.CheckBox checkBox_options_iPod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_options_touchScreen_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_options_surroundSystem_description;
        private System.Windows.Forms.Label label_options_iPod_price;
        private System.Windows.Forms.Label label_options_heatedSeats_price;
        private System.Windows.Forms.Label label_options_runningLights_price;
        private System.Windows.Forms.Label label_options_surroundSystem_price;
        private System.Windows.Forms.Label label_accessories_sportExhaust_price;
        private System.Windows.Forms.Label label_accessories_roofSpoiler_price;
        private System.Windows.Forms.Label label_accessories_rackPrice;
        private System.Windows.Forms.CheckBox checkBox_accessories_sideSkirts;
        private System.Windows.Forms.CheckBox checkBox_accessories_chromePackage;
        private System.Windows.Forms.CheckBox checkBox_accessories_frontSpoiler;
        private System.Windows.Forms.CheckBox checkBox_accessories_rearApron;
        private System.Windows.Forms.CheckBox checkBox_accessories_sportExhaust;
        private System.Windows.Forms.CheckBox checkBox_accessories_roofSpoiler;
        private System.Windows.Forms.CheckBox checkBox_accessories_rearRack;
        private System.Windows.Forms.Label label_accessories_rearApron_price;
        private System.Windows.Forms.Label label_accessories_frontSpoiler_price;
        private System.Windows.Forms.Label label_accessories_chromePackage_price;
        private System.Windows.Forms.Label label_accessories_chromePackage_description;
        private System.Windows.Forms.Label label_accessories_sideSkirts_price;
        private System.Windows.Forms.PictureBox pictureBox_total;
    }
}

