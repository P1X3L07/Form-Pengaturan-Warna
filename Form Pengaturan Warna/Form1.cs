using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Pengaturan_Warna
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnProses_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtBoxInput.Text.Substring(0, 4).ToLower() == "isi:")
                {
                    LblEmpty.Text = TxtBoxInput.Text.Substring(4);
                }
                else if (TxtBoxInput.Text.ToLower() == "hide")
                {
                    LblEmpty.Hide();
                }
                else if (TxtBoxInput.Text.ToLower() == "shown")
                {
                    LblEmpty.Show();
                }
                else if (TxtBoxInput.Text.Substring(0, 6).ToLower() == "warna:")
                {
                    if (TxtBoxInput.Text.Substring(6) == "default")
                    {
                        LblEmpty.ForeColor = Color.Black;
                    }
                    else if (TxtBoxInput.Text.Substring(6) == "red")
                    {
                        LblEmpty.ForeColor = Color.Red;
                    }
                    else if (TxtBoxInput.Text.Substring(6) == "blue")
                    {
                        LblEmpty.ForeColor = Color.Blue;
                    }
                    else if (TxtBoxInput.Text.Substring(6) == "green")
                    {
                        LblEmpty.ForeColor = Color.Green;
                    }
                    else if (TxtBoxInput.Text.Substring(6) == "orange")
                    {
                        LblEmpty.ForeColor = Color.Orange;
                    }
                }
                else if (TxtBoxInput.Text.ToLower() == "besarkan")
                {
                    LblEmpty.Font = new Font(LblEmpty.Font.Name, LblEmpty.Font.Size + 1);
                }
                else if (TxtBoxInput.Text.ToLower() == "kecilkan")
                {
                    LblEmpty.Font = new Font(LblEmpty.Font.Name, LblEmpty.Font.Size - 1);
                }
                else if (TxtBoxInput.Text.ToLower() == "restart")
                {
                    Application.Restart();
                }
            }
            catch(Exception exit)
            {
                MessageBox.Show("Sytax Tidak Ditemukan");
            }
        }

        private void LblInputData_Click(object sender, EventArgs e)
        {
            
        }

    }
}
