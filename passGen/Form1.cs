using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pGen
{
    public partial class fm_Main : Form
    {
        public fm_Main()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            string dic = "";
            string tmp = "";
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
            if (cb_Digits.Checked) dic += "0123456789";
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

            string pass = "";
            Random mran = new Random();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int index = Convert.ToUInt16(mran.NextDouble() * dic.Length) % dic.Length;
                char ScharS = dic[index];
                pass += Convert.ToString(ScharS);
            }
            tb_Result.Text = pass;
        }
    }
}
