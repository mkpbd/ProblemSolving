using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolving.ArrayProblems
{
    public class ProblemsSolved2
    {

        public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {

            int n = ranked.Count;
            int m = player.Count;
            int i = 0;
            int j = 0;
            int r = 1;

            List<int> res = new List<int>();
            res.Add(m);


            while (j < m)
            {
                if (i < n && ranked[i] > player[m - j - 1])
                {
                    i++;
                    if (ranked[i] != ranked[i - 1])
                    {
                        r++;
                    }
                }
                else
                {
                    res.Add(r);
                    j++;
                }
            }
            return res;

            //while(j < m)
            //{
            //    if(i < n && ranked[i]> player[m - j - 1])
            //    {
            //        i++;

            //        if (ranked[i] != ranked[i - 1])
            //        {
            //            r++;
            //        }


            //    }
            //    else
            //    {
            //        l[m - j - 1] = r;
            //        j++;
            //    }
            //}

            //return l;

        }



        public static int squares(int a, int b)
        {

            int result = 0;

            int minimum = (int)Math.Sqrt(a);
            int maximum = (int)Math.Sqrt(b);

            for (var i = minimum; i <= maximum; i++)
            {

                if (i * i >= a && i * i <= b) result++;
            }


            return result;
        }


        public static long repeatedString(string s, long n)
        {
            long firstStgringlenght = s.Length;

            long count = 0;
            long[] x = new long[firstStgringlenght + 1];

            for (var i = 1; i <= firstStgringlenght; i++)
            {
                if (s[i - 1].ToString() == "a") count++;

                x[i] = count;

            }


            long rr = (n / firstStgringlenght) * count + x[n % firstStgringlenght];


            return rr;



        }


        public static int equalizeArray(List<int> arr)
        {
            int[] x = new int[101]; int max = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                max = Math.Max(max, ++x[arr[i]]);
            }

            return arr.Count - max;
        }



        public static int jumpingOnClouds(List<int> c)
        {


            int count = 0;

            int i = 0;

            while (i < c.Count - 1)
            {
                if (i + 2 < c.Count && c[i + 2] == 0)
                {
                    count++;
                    i += 2;
                }
                else
                {
                    count++;
                    i++;
                }
            }

            return count;
        }




        public static List<int> acmTeam(List<string> topic)
        {
            List<int> subjectOfList = new List<int>();

            for (int x = 0; x < topic.Count; x++)
            {
                for (int y = x; y < topic.Count; y++)
                {
                    if (topic[y] == topic[x]) continue;

                    int subjectCount = 0;


                    for (int z = 0; z < topic[x].Length; z++)
                    {
                        if (topic[x][z] != '0' || topic[y][z] != '0') subjectCount++;
                    }

                    subjectOfList.Add(subjectCount);
                }


            }

            int maximumSubject = subjectOfList.Max();

            int items = subjectOfList.Where(x => x == maximumSubject).Count();

            return new List<int>() { maximumSubject, items };
        }


        public static int beautifulTriplets(int d, List<int> arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Count - d; i++)
            {
                int arrValue = arr[i];

                if (arr.Contains(arrValue + d) && arr.Contains(arrValue + 2 * d)) count++;
            }


            return count;
        }



        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {

            if (y1 > y2)
            {
                return 10000;
            }
            else if (y1 == y2 && m1 > m2)
            {
                return 500 * (m1 - m2);
            }
            else if (y1 == y2 && m1 == m2 && d1 > d2)
            {
                return 15 * (d1 - d2);
            }
            else
            {
                return 0;
            }
        }


        /*
     * Complete the 'chocolateFeast' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER c
     *  3. INTEGER m
     */

        public static int chocolateFeast(int n, int c, int m)
        {
            int cholates = n / c;

            int cholateWraper = cholates;

            while (cholateWraper >= m)
            {
                int cholateWrapperFrom = cholateWraper / m;
                cholates += cholateWrapperFrom;
                cholateWraper = cholateWrapperFrom + cholateWraper % m;
            }

            return cholates;
        }




        /*
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

        public static void kaprekarNumbers(int p, int q)
        {
            List<int> kaprekars = new List<int>();
            if (p == 1)
            {
                kaprekars.Add(1);
            }

            for (int i = p; i <= q; i++)
            {
                long squareLong = Convert.ToInt64(i) * Convert.ToInt64(i);
                string squareString = squareLong.ToString();
                if (squareString.Length >= 2)
                {
                    int left = int.Parse(squareString.Substring(0, squareString.Length / 2));
                    int right = 0;
                    if (squareString.Length % 2 == 0)
                    {
                        right = int.Parse(squareString.Substring(squareString.Length / 2, squareString.Length / 2));
                    }

                    else
                    {
                        right = int.Parse(squareString.Substring(squareString.Length / 2, squareString.Length / 2 + 1));
                    }

                    if (left + right == i)
                    {
                        kaprekars.Add(i);
                    }

                }
            }


            if (kaprekars.Count == 0)
            {
                Console.WriteLine("INVALID RANGE");
            }

            else
            {
                foreach (int kaprekar in kaprekars)
                {
                    Console.Write($"{kaprekar} ");

                }

            }


        }



        /*
     * Complete the 'serviceLane' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY cases
     */

        //public static List<int> serviceLane(int n, List<List<int>> cases)
        //{

        //}



        /*
     * Complete the 'workbook' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY arr
     */

        public static int workbook(int n, int k, List<int> arr)
        {

            int pageCount = 0;
            int chapter = 0;
            int special = 0;
            while (chapter < n)
            {
                int index = 0;
                while (arr[chapter] > 0)
                {
                    int remain = Math.Min(k, arr[chapter]);
                    if (pageCount >= index && pageCount < (index + remain)) special++;
                    arr[chapter] -= remain;
                    index += remain;
                    pageCount++;
                }
                chapter++;
            }
            return special;

        }



        /*
    * Complete the 'minimumDistances' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts INTEGER_ARRAY a as parameter.
    */

        public static int minimumDistances(List<int> a)
        {
            List<int> result = new List<int>();
            int minvalue = 0;
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] == a[j])
                    {
                        result.Add(Math.Abs(i - j));
                    }
                }
            }


            if (result.Count > 0)
            {
                minvalue = result[0];

                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] > minvalue)
                    {
                        continue;
                    }
                    else
                    {
                        minvalue = result[i];
                    }
                }

            }
            else
            {
                minvalue = -1;
            }

            return minvalue;
        }



        /*
     * Complete the 'howManyGames' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER d
     *  3. INTEGER m
     *  4. INTEGER s
     */

        public static int howManyGames(int p, int d, int m, int s)
        {
            // Return the number of games you can buy
            int resultCount = 0;
            while (s >= p)
            {
                s -= p;
                p = Math.Max(m, p - d);
                resultCount++;
            }
            return resultCount;
        }



        /*
     * Complete the 'stones' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER a
     *  3. INTEGER b
     */

        public static List<int> stones(int n, int a, int b)
        {
            n -= 1;
            List<int> result = new List<int>();
            result.Add(a * n);
            result.Add(b * n);
            for (int i = 1; i <= (n / 2); i++)
            {
                result.Add((a * i) + (b * (n - i)));
                result.Add((b * i) + (a * (n - i)));
            }
            result.Sort();
            return result.Distinct().ToList();

        }



        /*
     * Complete the 'fairRations' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY B as parameter.
     */

        public static string fairRations(List<int> B)
        {
            int count = 0;
            string result = string.Empty;
            for (int i = 0; i < B.Count - 1; i++)
            {
                if (B[i] % 2 != 0)
                {
                    B[i]++;
                    B[i + 1]++;
                    count += 2;
                }
            }

            if (B.Where(x => x % 2 != 0).Count() != 0)
                result = "NO";
            else
                result = count.ToString();

            return result;


        }


        public static int formingMagicSquare(List<List<int>> s)
        {
            List<int[,]> magicSquares = new List<int[,]>{
            new int[,]{{2,7,6},{9,5,1},{4,3,8}},
            new int[,]{{2,9,4},{7,5,3},{6,1,8}},
            new int[,]{{4,3,8},{9,5,1},{2,7,6}},
            new int[,]{{4,9,2},{3,5,7},{8,1,6}},
            new int[,]{{6,1,8},{7,5,3},{2,9,4}},
            new int[,]{{6,7,2},{1,5,9},{8,3,4}},
            new int[,]{{8,3,4},{1,5,9},{6,7,2}},
            new int[,]{{8,1,6},{3,5,7},{4,9,2}}
        };

            int minCost = 0;
            int count = 0;
            foreach (int[,] magicSquare in magicSquares)
            {

                int currentCost = 0;
                for (int i = 0; i < s.Count; i++)
                {
                    for (int j = 0; j < s.Count; j++)
                    {
                        currentCost += Math.Abs(magicSquare[i, j] - s[i][j]);
                    }
                }
                if (currentCost < minCost || count == 0) minCost = currentCost;
                count++;
            }
            return minCost;
        }


        public static string encryption(string s)
        {

            s = s.Replace(" ", " ");
            int lenght = s.Length;
            double square = Math.Sqrt(lenght);

            int row = (int)Math.Floor(square);
            int column = (int)Math.Ceiling(square);
            int bound = row == column ? row : row + 1;

            string result = "";

            for (int i = 0; i < bound; i++)
            {
                string word = "";
                int index = i;
                while (index < lenght)
                {
                    word = word + s[index];
                    index += column;
                }
                result = $"{result}{word} ";
            }
            return result;

        }

        /*
     * Complete the 'strangeCounter' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER t as parameter.
     */

        public static long strangeCounter(long t)
        {
            long first = 3; long second = 1; long third = 3;

            while (third < t)
            {
                first *= 2;
                second = third + 1;
                third = second + (first - 1);
            }

            return (first - (t - second));
        }



        public static int Count(HashSet<long> hashSet, int r, int c, int rd, int cd, int n)
        {
            int count = 0;
            int rr = r + rd, cc = c + cd;
            while (rr <= n && cc <= n && rr >= 1 && cc >= 1)
            {
                long hash = (long)rr + 131072 * (long)cc;
                if (!hashSet.Contains(hash))
                {
                    count++;
                    rr += rd;
                    cc += cd;
                }
                else
                {
                    return count;
                }
            }
            return count;
        }


        public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {
            HashSet<long> hashSet = new HashSet<long>();
            foreach (var v in obstacles)
            {
                long hash = (long)v[0] + 131072 * (long)v[1];
                hashSet.Add(hash);
            }
            int count = 0;
            count += Count(hashSet, r_q, c_q, 0, -1, n);
            count += Count(hashSet, r_q, c_q, 0, 1, n);

            count += Count(hashSet, r_q, c_q, -1, 1, n);
            count += Count(hashSet, r_q, c_q, 1, -1, n);

            count += Count(hashSet, r_q, c_q, -1, 0, n);
            count += Count(hashSet, r_q, c_q, 1, 0, n);

            count += Count(hashSet, r_q, c_q, -1, -1, n);
            count += Count(hashSet, r_q, c_q, 1, 1, n);
            return count;
        }


        /*
    * Complete the 'biggerIsGreater' function below.
    *
    * The function is expected to return a STRING.
    * The function accepts STRING w as parameter.
    */

        public static string biggerIsGreater(string w)
        {
            var possible = false;
            var charArray = w.ToArray();
            for (int i = w.Length - 2; i >= 0; i--)
            {

                var charsGreater = new List<int>();
                for (int j = i + 1; j < w.Length; j++)
                {
                    if ((int)charArray[i] % 32 < (int)charArray[j] % 32)
                    {
                        possible = true;
                        charsGreater.Add(j);
                    }
                }
                if (possible)
                {
                    var min = 0;
                    for (int k = 1; k < charsGreater.Count(); k++)
                    {
                        if ((int)charArray[charsGreater[k]] % 32 < (int)charArray[charsGreater[min]] % 32)
                        {
                            min = k;
                        }
                    }
                    var temp = charArray[i];
                    charArray[i] = charArray[charsGreater[min]];
                    charArray[charsGreater[min]] = temp;

                    var s = new string(charArray);

                    var p1 = s.Substring(0, i + 1);
                    var p2 = new string(s.Substring(i + 1, s.Length - i - 1).ToArray().OrderBy(x => x).ToArray());
                    return p1 + p2;
                }
            }

            return "no answer";



        }

        /*
    * Complete the 'organizingContainers' function below.
    *
    * The function is expected to return a STRING.
    * The function accepts 2D_INTEGER_ARRAY container as parameter.
    */

        public static string organizingContainers(List<List<int>> container)
        {


            int containerSize = container.Count;
            int[] row = new int[containerSize];
            int[] column = new int[containerSize];

            for (int i = 0; i < container.Count; i++)
            {
                for (int j = 0; j < container[i].Count; j++)
                {
                    row[i] += container[i][j];
                    column[i] += container[j][i];
                }
            }

            int ans = 0;
            for (int i = 0; i < containerSize; i++)
            {
                ans ^= row[i];
                ans ^= column[i];
            }
            return ans == 0 ? "Possible" : "Impossible";



        }


        /*
     * Complete the 'cavityMap' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY grid as parameter.
     */

        public static List<string> cavityMap(List<string> grid)
        {
            for (int i = 1; i < grid.Count - 1; i++)
            {
                for (int j = 1; j < grid[i].Length - 1; j++)
                {
                    if (
                        grid[i][j] > grid[i - 1][j] && grid[i][j] > grid[i + 1][j] &&
                        grid[i][j] > grid[i][j - 1] && grid[i][j] > grid[i][j + 1]
                        
                        )
                    {
                        var sb = new StringBuilder(grid[i]);
                        sb[j] = 'X';
                        grid[i] = sb.ToString();
                    }
                }
            }
            return grid;
        }


    }
}
