using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Structure_Demo_Windows
{
    public partial class Form1 : Form
    {
        //Create global reference
        Brain amoeba;

        //Define Brain structure
        public struct Brain
        {
            public string fact1;
            public string fact2;
            public string fact3;
            public string fact4;

            //Constructor - must have parameters
            public Brain(string f1, string f2, string f3, string f4)
            {
                fact1 = f1;
                fact2 = f2;
                fact3 = f3;
                fact4 = f4;
                MessageBox.Show("Your amoeba has been create and educated");
            }

            //Structure method
            public string brainDump()
            {
                string contents = "";
                contents = fact1 + Environment.NewLine;
                contents += fact2 + Environment.NewLine;
                contents += fact3 + Environment.NewLine;
                contents += fact4;
                return contents;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            string message;

            message = amoeba.brainDump();
            MessageBox.Show(message);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string f1, f2, f3, f4;
            f1 = "The weight of all the ants on earth is equal to the weight of" +
                   " all the humans on earth." + Environment.NewLine;
            f2 = "The average person spends 6 months of their life sitting at " +
                "red lights." + Environment.NewLine;
            f3 = "The electric chair was invented by a dentist." +
                Environment.NewLine;
            f4 = "No word in the English language rhymes with month, orange, " + "silver and purple.";

            //Construct the Amoeba
            amoeba = new Brain(f1, f2, f3, f4);
        }
    }
}
