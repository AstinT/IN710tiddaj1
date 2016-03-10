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

        //Add character
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {

            Character newCharacter = null;
            //getting name for txtName
            String name = txtName.Text;            

            //if txtName has some txt in it add
            if (name != "")
            {
                //Checking to see what kind of character type is selected
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

        private void btnBattle_Click(object sender, EventArgs e)
        {
            List<int> battlersList = new List<int>();

            //get all characters that are selected to battle
            foreach (int checkedIndex in checkedListBox1.CheckedIndices)
            {
                battlersList.Add(checkedIndex);
            }

            //Checks to see how many have been selected
            if (battlersList.Count == 2)
            {
                listBox1.Items.Clear();

                foreach (int battler in battlersList)
                {
                    BattleString(battler);
                }
            }
            //if more than two selected display this
            else
                MessageBox.Show("Please select 2 characters");
        }

        //Displays full character message
        private void BattleString(int battler)
        {
            listBox1.Items.Add(characterList[battler].StateName());
            listBox1.Items.Add(characterList[battler].Declaim());
            listBox1.Items.Add(characterList[battler].UseWeapon());
            listBox1.Items.Add("");
        }

        //change weapon
        private void btnChangeWeapon_Click(object sender, EventArgs e)
        {
            List<int> changeWeaponCharcterList = new List<int>();

            foreach (int checkedIndex in checkedListBox2.CheckedIndices)
            {
                changeWeaponCharcterList.Add(checkedIndex);
            }

            if (changeWeaponCharcterList.Count == 1)
            {
                foreach(int character in changeWeaponCharcterList)
                {
                    ChangeWeapon(character);
                }
                
            }
            else
                MessageBox.Show("Please select 1 character");
        }

        private void ChangeWeapon(int characterIndex)
        {
            if (rdSword.Checked)
                characterList[characterIndex].Weapon = new Sword();
            else if (rdKnife.Checked)
                characterList[characterIndex].Weapon = new Knife();
            else if (rdBow.Checked)
                characterList[characterIndex].Weapon = new Bow();
            else
                MessageBox.Show("Please select a weapon to change too.");
        }
    }
}