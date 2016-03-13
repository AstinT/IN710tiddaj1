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
        //Interface
        IEncryptDecryptMachine machine;

        public Form1()
        {
            InitializeComponent();           
        }

        //Encrypt button
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //encrypts using StringReverse method
            if (rbStringReverse.Checked)
            {
                machine = new StringReverse();
            }
            //encrypts using ROT13 method
            else if (rbRot13.Checked)
            {
                machine = new Rot13();
            }

            String input = tbInput.Text;
            tbOutput.Text = machine.Encrypt(input);
            tbInput.Text = "";
        }

        //Decrypt button
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //decrypts using StringReverse method
            if (rbStringReverse.Checked)
            {
                machine = new StringReverse();
            }
            //decrypts using Rot13 method
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
