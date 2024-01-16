using System;
using System.Collections;

namespace Demo
{
    //Calculte the total number of scores greater than 57 in serries
    //{31-,23,64,40,85,55,50,90)
    class SampleLambda
    {
        static void Main()
        {
            int[] scores = { -31, 23, 64, 40, 85, 55, 50, 99 };
            int highScores = scores.Where(n => n > 57).Count();
            Console.WriteLine("{0} scores are greater than 57" , highScores);
            Console.Read();
        }

    }
}