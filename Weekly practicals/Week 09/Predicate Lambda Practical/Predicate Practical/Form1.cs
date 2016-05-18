using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predicate_Practical
{
    public partial class Form1 : Form
    {
        //Constant
        private const int NUM_OF_GENERATED_RANDOMS = 10;

        //Fields
        List<int> randNumList;

        public Form1()
        {
            InitializeComponent();            
        }

        //Intialising
        private void Form1_Load(object sender, EventArgs e)
        {
            randNumList = null;
        }

        private void btnGenerateRandoms_Click(object sender, EventArgs e)
        {
            lbRandoms.Items.Clear();
            //Generates new list each time button is clicked
            randNumList = new List<int>();
            Random random = new Random();

            //Generates 50 random numbers. Adds to list and displays.
            for (int i = 0; i < NUM_OF_GENERATED_RANDOMS; i++)
            {
                int randomNum = random.Next(0, 100);
                randNumList.Add(randomNum);
                lbRandoms.Items.Add(randomNum);
            }
        }

        //Passed a Predicate delegate. Passed in as a lambda expression
        public void listLoopMethod(Predicate<int> operation)
        {
            if (randNumList != null)
            {
                //Makes a list of numbers depending what operation is passed in
                List<int> filteredNums = randNumList.FindAll(operation);

                foreach (int currInt in filteredNums)
                {
                    //Add all filtered nums too listbox
                    lbSelectedNumbers.Items.Add(currInt);
                }
            }
        }

        //Button methods
        private void btnEvenNumbers_Click(object sender, EventArgs e)
        {
            lbSelectedNumbers.Items.Clear();
            //Lambda expression - find all evens
            listLoopMethod((x) => (x % 2) == 0);
        }

        private void btnNumLess10_Click(object sender, EventArgs e)
        {
            lbSelectedNumbers.Items.Clear();
            //Lambda expression - find nums less than 10
            listLoopMethod((x) => x < 10);
        }
    }
}
