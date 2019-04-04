/*
 * Created by: Allan L
 * Created on: March 28, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
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

namespace UnicodeAllanL
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            {
                //local variables
                string letter;
                int counter;

                //clear listbox items
                lstUnicode.Items.Clear();

                //loop
                for (counter = 65; counter <= 90; counter++)
                {
                    letter = Char.ConvertFromUtf32(counter);
                    lstUnicode.Items.Add(letter + " -> " + counter);
                }
            }
        }
    }
}
