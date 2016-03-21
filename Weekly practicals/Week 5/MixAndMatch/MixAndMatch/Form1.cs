using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxes(cbHead);
            LoadComboBoxes(cbTorso);
            LoadComboBoxes(cbLegs);
        }

        public void LoadComboBoxes(ComboBox comboBoxToLoad)
        {
            comboBoxToLoad.Items.Add("Fairy");
            comboBoxToLoad.Items.Add("Frankenstein");
            comboBoxToLoad.Items.Add("Skeleton");
            comboBoxToLoad.Items.Add("Vampire");
            comboBoxToLoad.Items.Add("Werewolf");
            comboBoxToLoad.Items.Add("Witch");
        }

        private void btnMakeMonster_Click(object sender, EventArgs e)
        {
            if ((cbHead.SelectedItem != null) || (cbTorso.SelectedItem != null) || (cbLegs.SelectedItem != null))
            {
                String selectedHead = cbHead.SelectedItem.ToString();
                String selectedTorso = cbTorso.SelectedItem.ToString();
                String selectedLegs = cbLegs.SelectedItem.ToString();

                MonsterMaker monsterBuilder = new MonsterMaker(selectedHead, selectedTorso, selectedLegs, pbHead, pbTorso, pbLegs);
                monsterBuilder.createMonster();
            }
            else
                MessageBox.Show("Please select a head, torso and legs!");            
        }
    }
}
