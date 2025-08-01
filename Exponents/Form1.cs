﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:        John Kiper
 * Date:        07/30/2025
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int inputNum;
            int squaredNum;
            int cubedNum;
            // INPUT
            if (int.TryParse(xInputTextBox.Text, out inputNum))
            {
                // PROCESS
                /* calculate the square of the number and add it to the output - 
                 * do this with a method call that allows you to pass the number
                 * and then receive the answer */
                squaredNum = Square(inputNum);
                cubedNum = Cube(inputNum);

                /* calculate the cube of the number and add it to the output - 
                 * do this by creating a methd as in the squaring example above */

                // OUTPUT
                xOutputLabel.Text = $"Square: {squaredNum}\nCube: {cubedNum}";
                xOutputLabel.ForeColor = Color.Green;
                xOutputLabel.Visible = true;
                // set the output to visible

                // turn the Go button off
                xGoButton.Enabled = false;
               
                   
              
                   
        
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public int Square(int num)
        {
            // we will create this code in class
            return num * num;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            xInputTextBox.Text = "";
            xOutputLabel.Text = "";
            xOutputLabel.Visible = false;
            // turn the output to invisible
            xGoButton.Enabled = true;
            // turn the Go button back on
            xInputTextBox.Focus();
        }

    }
}
