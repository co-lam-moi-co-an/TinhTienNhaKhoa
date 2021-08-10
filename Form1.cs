using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienNhaKhoa
{
    public partial class Form1 : Form
    {
        string erorMgs;
        public Form1()
        {
            InitializeComponent();
        }

        private void chkTramRang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCaoVoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numNhoRang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (ValidateText(txtHoTen))
            {
                int tongThietHai = 0;
                if (chkTramRang.CheckState.ToString().Equals("Checked"))
                {
                    tongThietHai += 200000;
                }
                if (chkCaoVoi.CheckState.ToString().Equals("Checked"))
                {
                    tongThietHai += 300000;
                }
                tongThietHai += (int)numNhoRang.Value * 100000;
                txtTongTien.Text = tongThietHai.ToString();
            }

            
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            erorMgs = "";
            ValidateText(sender);
            Console.WriteLine("con cu");
            txtMessage.Text = erorMgs;
        }
        private bool ValidateText(object sender)
        {
            TextBox txtHoTen = (TextBox)sender;
            if (txtHoTen.Text == "")
            {
                errHoTen.SetError(txtHoTen, "Số không được rỗng!");
                erorMgs += txtHoTen.Name + " không được để rỗng!\n";
                return false;
            }
            try
            {
                string pattern = "^[a-zA-Z\\s]*$";
                Match m = Regex.Match(txtHoTen.Text, pattern, RegexOptions.IgnoreCase);
                if (!m.Success)
                {
                    throw new Exception();
                }
                    
            }
            catch (Exception)
            {
                errHoTen.SetError(txtHoTen, "Số đã nhập không hợp lệ!");
                erorMgs += txtHoTen.Name + " nhập không hợp lệ!\n";
                return false;
            }
            errHoTen.SetError(txtHoTen, "");
            erorMgs = "";
            return true;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
