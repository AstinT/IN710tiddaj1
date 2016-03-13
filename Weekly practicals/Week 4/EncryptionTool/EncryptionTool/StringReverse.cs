using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public class StringReverse : IEncryptDecryptMachine
    {
        //Reverse Encrypt method
        public String Encrypt(String stringToEncrypt)
        {
            char[] charArray = stringToEncrypt.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }

        //Reverse Decrypt method
        public String Decrypt(String stringToDecrypt)
        {
            char[] charArray = stringToDecrypt.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }
    }
}
