using NgulakKopy.Views.Petani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgulakKopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedItem.ToString() == "Petani")
            {
                this.Hide();
                MessageBox.Show("Sukses, silahkan melakukan login atau registrasi", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginPetani lp = new LoginPetani();
                lp.Show();
            }
        }
    }
}
