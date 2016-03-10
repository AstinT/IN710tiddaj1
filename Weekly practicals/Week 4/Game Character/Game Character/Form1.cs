using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        List<Character> characterList = new List<Character>;

        public Form1()
        {
            InitializeComponent();

            characterList.Add(new King("Ragnar"));
            characterList.Add(new Queen("Lagatha"));
            characterList.Add(new Knight("Bjorn"));
            characterList.Add(new Troll("Floki"));
        }
    }
}
)