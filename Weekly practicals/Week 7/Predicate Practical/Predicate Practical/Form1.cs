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

        //Delegate
        Predicate<int> selectNums;

        //Properties
        List<int> randNumList;

        public Form1()
        {
            InitializeComponent();            
        }

        //Intialising
        private void Form1_Load(object sender, EventArgs e)
        {
            selectNums = null;
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

        //Checks if passed in int is even
        public bool isEven(int inputData)
        {
            bool isAnEvenNumber = ((inputData % 2) == 0);
            return isAnEvenNumber;
        }

        //Checks if passed in int is less than ten
        public bool isLessThanTen(int inputData)
        {
            bool isLessThanTen = (inputData < 10);
            return isLessThanTen;
        }

        //Gets passed a Predicate method and loops over randNumList
        public void listLoopMethod(Predicate<int> operation)
        {
            if (randNumList != null)
            {
                foreach (int currInt in randNumList)
                {
                    if (operation(currInt))
                    {
                        lbSelectedNumbers.Items.Add(currInt);
                    }
                }
            }
        }

        //Button methods
        private void btnEvenNumbers_Click(object sender, EventArgs e)
        {
            lbSelectedNumbers.Items.Clear();
            selectNums = new Predicate<int>(isEven);
            listLoopMethod(selectNums);
        }

        private void btnNumLess10_Click(object sender, EventArgs e)
        {
            lbSelectedNumbers.Items.Clear();
            selectNums = new Predicate<int>(isLessThanTen);
            listLoopMethod(selectNums);
        }
    }
}
