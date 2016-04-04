using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNight
{
    //Static class
    public static class Scorer
    {
        //Constants
        private const int ADULT_CORRECT = 10;
        private const int ADULT_INCORRECT = 1;
        private const int CHILDREN_CORRECT = 15;

        //Static scoring method for adults
        public static int AdultScore(int correct, int incorrect)
        {
            int score;
            score = ADULT_CORRECT * correct;
            score = score - (ADULT_INCORRECT * incorrect);

            return score;
        }

        //Static scoring method for children
        public static int ChildrenScore(int correct, int incorrect)
        {
            int score;
            score = CHILDREN_CORRECT * correct;

            return score;
        }
    }
}
