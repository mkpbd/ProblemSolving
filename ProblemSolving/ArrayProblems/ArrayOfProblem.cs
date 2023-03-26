using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.ArrayProblems
{
    public static class ArrayOfProblem
    {
        public static List<int> BreakingRecords(List<int> scores)
        {

            int min = scores[0];
            int max = scores[0];

            int brokentMin = 0;
            int maxBrokent = 0;


            for (var i = 1; i < scores.Count; i++)
            {
                if (scores[i] > max)
                {
                    maxBrokent++;
                    max = scores[i];

                }

                else if (scores[i] < min)
                {
                    brokentMin++;
                    min = scores[i];
                }
            }


            return new List<int> { maxBrokent, brokentMin };

        }


        public static int birthday(List<int> s, int d, int m)
        {
            int finalResult = 0;

            int changeValue = 0;

            for (var i = 0; i < s.Count - (m - 1); i++)
            {
                for (var j = i; j < (i + m); j++)
                {
                    changeValue += s[j];
                }

                if (changeValue == d)
                {
                    finalResult++;
                }
                changeValue = 0;
            }


            return finalResult;


        }


        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {


            var result = 0;
            var xk = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        if ((ar[i] + ar[j]) % k == 0)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }


        public static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> results = new Dictionary<int, int>();

            foreach (var i in arr.Distinct())
            {
                results.Add(i, 0);
            }

            for (var j = 0; j < arr.Count; j++)
            {
                if (results.ContainsKey(arr[j]))
                {
                    results[arr[j]]++;
                }
            }


            return results.OrderByDescending(x => x.Value).ThenBy(x => x.Key).First().Key;


        }


        public static string dayOfProgrammer(int year)
        {

            bool isYear;

            isYear = (year < 1981 && year % 4 == 0) || (year > 1918) && (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? true : false;


            if (year == 1918) return "26.09.1918";

            if (isYear) return $"12.09.{year}";

            return $"13.09.{year}";



        }



        public static void bonAppetit(List<int> bill, int k, int b)
        {

            var resumeBill = bill.Sum(b => b) - bill[k];

            if (resumeBill / 2 == b)
            {
                Console.WriteLine("Bon Appetit");

                return;
            }

            Console.WriteLine(Math.Abs((resumeBill / 2) - b));

        }



        public static int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> results = new();

            foreach (var key in ar.Distinct())
            {
                results.Add(key, 0);
            };

            foreach (var key in ar)
            {
                if (results.ContainsKey(key))
                {
                    results[key]++;
                }
            }

            int pairValue = 0;

            foreach (var item in results)
            {
                pairValue += item.Value / 2;
            }

            return pairValue;
        }


        public static int pageCount(int n, int p)
        {

            int formatStart = p / 2;

            int formatEnd = (n % 2 == 0 ? (n - p + 1) / 2 : (n - p) / 2);


            return Math.Min(formatStart, formatEnd);
        }



        public static int countingValleys(int steps, string path)
        {
            int count = 0;

            int height = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    height++;
                }
                else
                {
                    height--;
                }

                if (height == 0 && path[i] == 'U') count++;
            }

            return count;
        }


        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maximumConst = -1;

            for (var i = 0; i < keyboards.Length; i++)
            {

                for (var j = 0; j < drives.Length; j++)
                {
                    int totalCost = keyboards[i] + drives[j];

                    if (totalCost <= b && totalCost > maximumConst)
                    {
                        maximumConst = totalCost;
                    }
                }
            }

            return maximumConst;

        }


        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {
            var catA = Math.Abs(x - z);
            var catB = Math.Abs(y - z);

            if (catA == catB) return "Mouse C";

            if (catA < catB) return "Cat A";
            if (catA > catB) return "Cat B";

            return "";

        }


        public static int pickingNumbers(List<int> a)
        {
            a.Sort();
            int max = 0;
            int value = a[0];
            int count = 1;


            for (int i = 1; i < a.Count; i++)
            {
                if (Math.Abs(value - a[i]) <= 1)
                {
                    count++;

                    if (count > max) max = count;
                }
                else
                {
                    value = a[i];
                    count = 1;
                }
            }

            return max;
        }


        public static int hurdleRace(int k, List<int> height)
        {
            int result = 0;
            var re = from a in height orderby a descending select a;

            if (re.FirstOrDefault() > k)
            {
                result = re.FirstOrDefault() - k;
            }
            else
            {
                result = 0;
            }

            return result;
        }


        public static int utopianTree(int n)
        {
            var height = 1;

            for (var j = 1; j < n; j++)
            {
                height = j % 2 == 0 ? height + 1 : height;
            }

            return height;

        }


        public static int beautifulDays(int i, int j, int k)
        {


            int beautifulDay = 0;

            for (int x = 0; x + i <= j; x++)
            {
                int number = x + i;

                string numberToString = Convert.ToString(number);

                string reveserToString = string.Empty;

                for (int l = numberToString.Length; l > 0; l--)
                {
                    reveserToString += numberToString[l - 1];
                }

                int reverseNumber = Convert.ToInt32(reveserToString);

                var value = Math.Abs((number - reverseNumber));

                if (value % k == 0)
                {
                    beautifulDay++;
                }
                else
                {
                    beautifulDay = beautifulDay;
                }

            }


            return beautifulDay;
        }





        public static int viralAdvertising(int n)
        {
            int Shared = 5;
            int Liked = 2;
            int Cumulative = Liked;

            while (n > 1)
            {
                Shared = Liked * 3;
                Liked = Shared / 2;

                Cumulative += Liked;
                n--;
            }


            return Cumulative;
        }




        public static int saveThePrisoner(int n, int m, int s)
        {
            int c = (m % n) + s - 1;

            if (c > n) c -= n;
            if (c == 0) return n;
            return c;
        }

        public static long taumBday(int b, int w, int bc, int wc, int z)
        {

            long minmumPriceBlack = Math.Min(bc + z, wc);
            long MinumPriceWhite = Math.Min(bc, wc + z);


            return (minmumPriceBlack * w) + (MinumPriceWhite * b);

        }



        public static int findDigits(int n)
        {

            string getNumberToString = Convert.ToString(n);
            int count = 0;

            for (int i = 0; i < getNumberToString.Length; i++)
            {

                if (getNumberToString[i].ToString() == 0.ToString()) continue;

                if (getNumberToString[i].ToString() != 0.ToString())
                {
                    int.TryParse(getNumberToString[i].ToString(), out int divied);
                    if (n % divied == 0)
                        count++;
                }
            }

            return count;

        }




        public static List<int> cutTheSticks(List<int> arr)
        {
            arr.Sort();

            List<int> list = new List<int>();
            int temp = int.MinValue;

            for (int i = 0; i < arr.Count; i++)
            {

                if (temp != arr[i])
                {
                    list.Add((arr.Count - i));
                    temp = arr[i];
                }
            }

            return list;

        }





        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
             List<int> list = new List<int>();

            foreach(var que in queries)
            {
                int i = que - k % a.Count;
                int val = i < 0 ? Math.Abs(i) : i;
                list.Add(a[i < 0 ? ^Math.Abs(i) : i]);
            }

            return list;
        }


        public static List<int> permutationEquation(List<int> p)
        {

            List<int> list = new List<int> ();

            int n = p.Count;

            for(int i = 1; i <= n; i++)
            {
                int xValueOfIndex = p.IndexOf(i);
                int yValueFoIndex = p.IndexOf(xValueOfIndex + 1) + 1;

                list.Add(yValueFoIndex);
            }


            return list;
        }



        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c, int k)
        {
            int energy = 100;
            int indexValue = 0;
            int lengthOfC = c.Length;

            do
            {
                if (c[indexValue] == 1) energy -= 2;
                energy--;

                indexValue = (indexValue + k) % lengthOfC;

            } while (indexValue != 0);

            return energy;

        }




        public static string appendAndDelete(string s, string t, int k)
        {
            if(k >= t.Length + s.Length) return "Yes";

            int same = Math.Min(t.Length, s.Length);

            for(int i = 0; i < Math.Min(t.Length, s.Length); i++)
            {
                if (t[i] != s[i]) {
                    same = i; break;
                }
            }

            k -= t.Length - same;
            k -= s.Length - same;


            return k>=0 && k%2 ==0 ? "Yes" : "No";
        }


    }




}

