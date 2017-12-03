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
            InitializeComponent();

            foreach (string result in res)
            {
                lb_results.Items.Add(result);
            }
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
