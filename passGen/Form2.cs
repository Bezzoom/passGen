using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace passGen
{
    public partial class fm_Result : Form
    {
        public fm_Result(Array res)
        {
//          Initialize form
            InitializeComponent();

//          Fill ListBox with new passwords
            foreach (string result in res)
            {
                lb_results.Items.Add(result);
            }

//          Add some events
            lb_results.SelectedValueChanged += new System.EventHandler(lb_results_SelectIndexChanged);
        }

        private void lb_results_SelectIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = lb_results.SelectedIndex;
            Clipboard.SetText(lb_results.SelectedItem.ToString());

            lb_results.Items.RemoveAt(i);
            lb_results.Items.Insert(i, "COPIED!!!");
        }
    }
}
