using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enc12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Eset = 4;
        public void Enc_Password()
        {
            int eset = Eset;
            string str_pass_origin = this.pass_origin.Text;
            string str_pass_enc = "";
            for(int i =0; i < str_pass_origin.Length; i++)
            {
                char ch = str_pass_origin[i];
                int res = (((int)(ch) + eset))% 127;
                char ch_enc = (char)(res);
                str_pass_enc += "" + ch_enc;
            }
            pass_after.Text = str_pass_enc;
        }
        public void Dec_Password()
        {
            int eset = Eset;
            string str_pass_enc = this.pass_after.Text;
            string str_pass_origin = "";

            for(int i = 0; i < str_pass_enc.Length; i++)
            {
                char ch_enc = str_pass_enc[i];
                int res = ((int)ch_enc - eset) % 127;
                if(res < 0)
                {
                    res = 127 - res;
                }
                char ch = (char)res;
                str_pass_origin += "" + ch;
            }
            //חדששששששששששש
            MessageBox.Show(str_pass_origin);

       
        }
        private void ENC_Click(object sender, EventArgs e)
        {
            Enc_Password();
        }

        private void DEC_Click(object sender, EventArgs e)
        {
            Dec_Password();
        }

        private void update_eset(object sender, EventArgs e)
        {
            try
            {
                this.Eset = int.Parse(Heset.Text);
            }
            catch
            {
                MessageBox.Show("הזנת ערכים לא תקינים במערכת ");
                Heset.Text = ""+this.Eset;
                return ;
            }
          
            
        }
    }
}
