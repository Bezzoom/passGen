using System;
using System.Windows.Forms;

namespace passGen { 
    public partial class fm_Main : Form {
        public fm_Main() {
            InitializeComponent();
            notifyIcon1.Visible = false;

            this.Resize += new System.EventHandler(this.fm_Main_R);
        }

        private void fm_Main_R (object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e) {
            string dic = "";
            string tmp = "";

            int count = Convert.ToInt16(num_pass_count.Value);

            string [] passwords = new string[count];

            Random mran = new Random();

            for (int j = 0; j < count; j++)
            {
                string pass = "";

                if (cb_Digits.Checked) dic += "0123456789";

                if (cb_Capitalize.Checked)
                {
                    char nchar;
                    for (int i = 65; i < 91; i++)
                    {
                        nchar = (char)i;
                        tmp += Convert.ToString(nchar);
                    }
                    dic += tmp;
                }

                if (cb_Small.Checked)
                {
                    tmp = "";
                    char nchar;
                    for (int i = 97; i < 123; i++)
                    {
                        nchar = (char)i;
                        tmp += Convert.ToString(nchar);
                    }
                    dic += tmp;
                }

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    int index = Convert.ToUInt16(mran.NextDouble() * dic.Length) % dic.Length;
                    char ScharS = dic[index];
                    pass += Convert.ToString(ScharS);
                }

                passwords[j] = pass;
            }

            Form res = new fm_Result(passwords);
            res.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
