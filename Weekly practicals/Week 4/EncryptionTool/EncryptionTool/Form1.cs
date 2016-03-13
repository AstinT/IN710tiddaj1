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
        IEncryptDecryptMachine machine;

        public Form1()
        {
            InitializeComponent();           
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rbStringReverse.Checked)
            {
                machine = new StringReverse();
            }
            else if (rbRot13.Checked)
            {
                machine = new Rot13();
            }

            String input = tbInput.Text;
            tbOutput.Text = machine.Encrypt(input);
            tbInput.Text = "";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (rbStringReverse.Checked)
            {
                machine = new StringReverse();
            }
            else if (rbRot13.Checked)
            {
                machine = new Rot13();
            }

            String input = tbInput.Text;
            tbOutput.Text = machine.Decrypt(input);
            tbInput.Text = "";
        }
    }
}
