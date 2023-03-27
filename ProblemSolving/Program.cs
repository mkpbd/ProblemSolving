using ProblemSolving.ArrayProblems;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var rr =     ArrayOfProblem.BreakingRecords(new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 });
            var rr =     ArrayOfProblem.BreakingRecords(new List<int> { 3, 4 ,21, 36, 10 ,28, 35, 5, 24, 42 });

            //for(var item = 0; item < rr.Count; item++)
            //{
            //    Console.WriteLine(rr[item]+ "");
            //}

            //var bb =  ArrayOfProblem.birthday(new List<int> { 1, 1, 1, 1, 1, 1 }, 3, 2);
            // var bb =  ArrayOfProblem.birthday(new List<int> { 4 }, 4, 1);
            //var bb =  ArrayOfProblem.divisibleSumPairs(6,3,new List<int> { 1, 3, 2, 6, 1, 2 });
            //var bb =  ArrayOfProblem.countingValleys(8, "UDDDUDUU");
            //var bb =  ArrayOfProblem.beautifulDays(20, 23, 6);
            //var bb =  ArrayOfProblem.findDigits(1012);


            //var abc = ArrayOfProblem.cutTheSticks(new List<int>() { 5, 4, 4, 2, 2, 8 });
            var abc = ArrayOfProblem.circularArrayRotation(new List<int>() { 3,2,3 },2,new List<int>() { 3});

            // new arr 

         //   var cc = ProblemsSolved2.ClimbingLeaderboard(new List<int> { 100, 100, 50, 40, 40, 20, 10, }, new List<int> { 5, 25, 50, 120 });
            //var cc = ProblemsSolved2.squares(3,9);
            //var cc = ProblemsSolved2.repeatedString("aba",10);
            //var cc = ProblemsSolved2.equalizeArray(new List<int>{ 3, 3, 2, 1, 3});
            var cc = ProblemsSolved2.equalizeArray(new List<int>{ 1 ,2, 3 ,1, 2, 3, 3, 3 });

        }
    }
}