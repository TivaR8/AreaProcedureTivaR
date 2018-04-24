using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 24-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Area Procedure
 * This program calculates the area of a rectangle with pass by value
*/

namespace AreaProcedureTivaR
{
    public partial class frmAreaProcedure : Form
    {
        public frmAreaProcedure()
        {
            InitializeComponent();
        }

        // Function: CalculateArea
        // Input: int length, int width
        // Output: void
        // Description Takes the length and width passed by value and displays a message box
        public void CalculateArea(int length, int width)
        {
            // Declare local variables
            int area;

            // Calculate area with length and width
            area = length * width;

            // Display message box with the calculated area
            MessageBox.Show("The area is : " + area + " squared units.", "Area Answer");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare local variables
            int userLength;
            int userWidth;

            // Convert the input length and width from String to int and make them variables
            userLength = Convert.ToInt16(this.txtLengthBox.Text);
            userWidth = Convert.ToInt16(this.txtWidthBox.Text);

            // Call the function to calculate the area passing the arguments by value
            this.CalculateArea(userLength, userWidth);
        }
    }
}
