using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Numero
{
    public partial class Main : Form
    {
        private int counter = 0;

        private int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                if (value < 0)
                    return;

                counter = value;

                counterLabel.Text = counter.ToString();
            }
        }

        public Main()
        {
            InitializeComponent();
            Counter = 0;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {

        }
    }
}