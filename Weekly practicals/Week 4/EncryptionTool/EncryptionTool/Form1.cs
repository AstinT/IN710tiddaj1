using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionTool
{
    public partial class Form1 : Form
    {
        StringReverse stringReverse;
        Rot13 rot13;

        public Form1()
        {
            InitializeComponent();
            
            stringReverse = new StringReverse();
            rot13 = new Rot13();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rbStringReverse.Checked)
            {
                String input = tbInput.Text;
                tbOutput.Text = stringReverse.Encrypt(input);
                tbInput.Text = "";
            }
            else if (rbRot13.Checked)
            {
                String input = tbInput.Text;
                tbOutput.Text = rot13.Encrypt(input);
                tbInput.Text = "";
            }
            else
            {
                MessageBox.Show("Please select an encryption algorithm.");
            }
        }
    }
}
