/*
Created by Matthew Ho
Created on 11-09-15
Created for ICS3U
Assignment #4-06
This program checks if two strings are the same but is not case sensitive.
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

namespace StringEquality
{
    public partial class frmStringEquality : Form
    {
        public bool StringEquality(string first, string second)
        {
            //This checks if two strings are the same but is not case sensitive.

            //Variables
            bool trueOrFalse;
            string firstUpper;
            string secondUpper;

            firstUpper = first.ToUpper();
            secondUpper = second.ToUpper();

            //Process
            if(firstUpper == secondUpper)
            {
                trueOrFalse = true;
            }
            else
            {
                trueOrFalse = false;
            }
            //Return value
            return trueOrFalse;
        }

        public frmStringEquality()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Variables
            string string1 = this.txtString1.Text;
            string string2 = this.txtString2.Text;
            bool trueOrFalse;

            //Call function
            trueOrFalse = StringEquality(string1, string2);

            //Output
            if (trueOrFalse == true)
            {
                this.lblAnswer.Text = "These are the same.";
            }
            else
            {
                this.lblAnswer.Text = "These are not the same.";
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Exit
            this.Close();
        }
    }
}
