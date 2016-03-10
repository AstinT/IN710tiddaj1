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
        List<Character> characterList = new List<Character>();

        public Form1()
        {
            InitializeComponent();

            //Creating initial characters
            characterList.Add(new King("Ragnar"));
            characterList.Add(new Queen("Lagatha"));
            characterList.Add(new Knight("Bjorn"));
            characterList.Add(new Troll("Floki"));

            UpdateCheckedListBox();
        }

        public void UpdateCheckedListBox()
        {
            //Clearing checkedListBoxes
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            //Adding characters to checkedListBox
            foreach (Character character in characterList)
            {
                checkedListBox1.Items.Add(character.Name);
                checkedListBox2.Items.Add(character.Name);
            }
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            Character newCharacter = null;
            String name = txtName.Text;            

            if (name != "")
            {
                if (rdKing.Checked)
                    newCharacter = new King(name);
                else if (rdQueen.Checked)
                    newCharacter = new Queen(name);
                else if (rdKnight.Checked)
                    newCharacter = new Knight(name);
                else if (rdTroll.Checked)
                    newCharacter = new Troll(name);
                else
                    MessageBox.Show("Please select a character type");

                if (newCharacter != null)
                {
                    characterList.Add(newCharacter);
                    txtName.Clear();
                }

                UpdateCheckedListBox();
            }
            else
                MessageBox.Show("Please enter a name");            
        }
    }
}