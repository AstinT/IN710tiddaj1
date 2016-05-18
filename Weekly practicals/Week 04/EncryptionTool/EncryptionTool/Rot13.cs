using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public class Rot13 : IEncryptDecryptMachine
    {
        public String Encrypt(String stringToEncrypt)
        {
            //Convert string to char array
            char[]  arrayToEncrypt = stringToEncrypt.ToCharArray();
            for (int i = 0; i < arrayToEncrypt.Length; i++)
            {
                //Casts letter to number
                int number = (int)arrayToEncrypt[i];

                //lowercase
                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                //uppercase
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                //overwrites char letter to char number in array
                arrayToEncrypt[i] = (char)number;
            }
            //returns char array as a string
            return new string(arrayToEncrypt);
        }

        //Same code as Encrypt method
        public String Decrypt(String stringToDecrypt)
        {
            return Encrypt(stringToDecrypt);
        }
    }
}
