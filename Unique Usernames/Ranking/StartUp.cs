using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var validContest = new Dictionary<string, string>();

            var submision = new Dictionary<string, Dictionary<string, int>>();


            string infoContest = Console.ReadLine();

            infoContest = AddInfoContest(validContest, infoContest);

            string infoSubmisionContest = Console.ReadLine();
            infoSubmisionContest = AddSubmisionContest(validContest, submision, infoSubmisionContest);

            string bestPlayer = string.Empty;
            int bestScore = int.MinValue;


            foreach (var (nameKeys, nameContestValue) in submision)
            {
                int currScore = 0;
                foreach (var item in nameContestValue)
                {
                    currScore += item.Value;
                }

                if (currScore > bestScore)
                {
                    bestScore = currScore;
                    bestPlayer = nameKeys;
                }
            }

            //            Best candidate is Tanya with total 1350 points.
            //Ranking:

            Console.WriteLine($"Best candidate is {bestPlayer} with total {bestScore} points.");
            Console.WriteLine($"Ranking:");

            //            Nikola
            //#  C# Fundamentals -> 200
            //#  Part One Interview -> 120
            //Tanya
            //#  Js Fundamentals -> 400
            //#  Algorithms -> 380
            //#  C# Fundamentals -> 350
            //#  Part One Interview -> 220

            foreach (var (nameKey, nameContName) in submision.OrderBy(x => x.Key))
            {
                Console.WriteLine(nameKey);
                foreach (var contNameandScore in nameContName.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contNameandScore.Key} -> {contNameandScore.Value}");
                }
            }





        }

        private static string AddSubmisionContest(Dictionary<string, string> validContest, Dictionary<string, Dictionary<string, int>> submision, string infoSubmisionContest)
        {
            while (infoSubmisionContest != "end of submissions")
            {
                string[] infoSumCon = infoSubmisionContest.Split("=>");
                string nameContest = infoSumCon[0];
                string passContest = infoSumCon[1];
                string nameStudent = infoSumCon[2];
                int scoreStudent = int.Parse(infoSumCon[3]);



                if (validContest.ContainsKey(nameContest) && validContest.ContainsValue(passContest))
                {
                    if (!submision.ContainsKey(nameStudent))
                    {
                        submision.Add(nameStudent, new Dictionary<string, int>());
                    }

                    if (!submision[nameStudent].ContainsKey(nameContest))
                    {
                        int currScore = 0;
                        if(submision[nameStudent].ContainsKey(nameContest))
                        {
                            currScore = submision[nameStudent][nameContest];
                            if(currScore > scoreStudent)
                            {
                                submision[nameStudent].Add(nameContest, currScore);
                            }
                            else
                            {
                                submision[nameStudent].Add(nameContest, scoreStudent);
                            }
                        }
                        else
                        {
                            submision[nameStudent].Add(nameContest, scoreStudent);
                        }

                        

                    }


                }



                infoSubmisionContest = Console.ReadLine();
            }

            return infoSubmisionContest;
        }

        private static string AddInfoContest(Dictionary<string, string> validContest, string infoContest)
        {
            while (infoContest != "end of contests")
            {
                string[] nameAndPassword = infoContest
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string name = nameAndPassword[0];
                string password = nameAndPassword[1];

                if (!validContest.ContainsKey(name))
                {
                    validContest.Add(name, password);
                }


                infoContest = Console.ReadLine();
            }

            return infoContest;
        }
    }
}
