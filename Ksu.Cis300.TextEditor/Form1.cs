/*
Frank Hatcher
Lab 2
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

namespace Ksu.Cis300.TextEditor
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Open file click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Unable to open:" + uxOpenFileDialog.FileName);
                string fn = uxOpenFileDialog.FileName;
                //
                // Process the file.
                //
            }
            else
            {
                MessageBox.Show("Unable to open:" + uxOpenFileDialog.FileName);
            }
            // Otherwise, do nothing.

        }

        /// <summary>
        /// Save file dialog handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSave_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Unable to write:" + uxSaveFileDialog.FileName);
                string fn = uxSaveFileDialog.FileName;
                //
                // Process the file.
                //
            }
            else
            {
                MessageBox.Show("Unable to write:" + uxSaveFileDialog.FileName);
            }
        }
    }
}
