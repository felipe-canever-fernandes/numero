using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Numero
{
    public partial class Main : Form
    {
        const string fileName = "counter.dat";
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

                minusButton.Enabled = counter > 0;
                counterLabel.Text = counter.ToString();
            }
        }

        public Main()
        {
            InitializeComponent();
            LoadCounter();
        }

        private void LoadCounter()
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    Counter = reader.ReadInt32();
                }
            }
            catch (FileNotFoundException)
            {
                Counter = 0;
            }
        }

        private void SaveCounter()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(Counter);
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            Counter -= 1;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            Counter += 1;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCounter();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Numero was created by Felipe Canever Fernandes <felipe.canever.fernandes@outlook.com>",
                "About Numero",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}