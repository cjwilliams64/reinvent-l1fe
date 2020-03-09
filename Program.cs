using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MatchingPairsGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            //these will represent a different symbol on the grid we're making
            //4 pairs!
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v","w", "w", "z","z"
        };

        public Form1()
        {
            InitializeComponent(); //the moment the app loads, the method below will begin
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            // 
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                Label iconLabel = c as Label; //creates a c variable that stores each variable one at a time. new name will be iconLabel
                if (iconLabel != null) //makes sure the conversion works, then next statements will run
                {
                    int randomNumber = random.Next(icons.Count);  //creates a random number that will correspond to ONE item in the icon list. the Next method returns the random number. the Count property determines the range the numbers will reach (1-8)
                    iconLabel.Text = icons[randomNumber]; //assigns an icon list item to a text property of the iconLabel

                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);  //removes the individual icon (from the list) that has been added to the form
                }
            }
        }

    }
}