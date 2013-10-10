/*
 *      Form2.cs
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

    public partial class Form_About : Form {

        public Form_About() {
            InitializeComponent();
        }// end of Form_About constructor

        private void buttons_exitAbout_Click(object sender, EventArgs e) {
            this.Close();
        }// end of buttons_exitAbout_Click method

        private void richTextBox_aboutParagraph_TextChanged(object sender, EventArgs e) {

        }// end of richTextBox_aboutParagraph_TextChanged method
    }// end of Form_About class

}// end of assignment2_michealWalls namespace
