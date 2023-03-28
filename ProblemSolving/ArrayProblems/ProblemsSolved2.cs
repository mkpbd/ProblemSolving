using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.ArrayProblems
{
    public  class ProblemsSolved2
    {

        public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {

            int n = ranked.Count ;
            int m = player.Count ;
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

            for(var i = minimum; i <= maximum; i++) {
            
                if(i * i >= a && i*i <=b) result++;
            }


            return result;
        }


        public static long repeatedString(string s, long n)
        {
            long firstStgringlenght = s.Length;

            long count = 0;
            long[] x = new long[firstStgringlenght + 1];

            for(var i =1; i <= firstStgringlenght; i++)
            {
                if (s[i-1].ToString() == "a") count++;

                x[i] = count;

            }


            long rr = (n / firstStgringlenght) * count + x[n % firstStgringlenght];


            return rr;
            


        }


        public static int equalizeArray(List<int> arr)
        {
            int[] x = new int[101]; int max = 0;

            for(int i = 0; i < arr.Count; i++)
            {
                max = Math.Max(max, ++x[arr[i]]);
            }

            return arr.Count - max;
        }



        public static int jumpingOnClouds(List<int> c)
        {


            int count = 0;

            int i = 0;

            while(i < c.Count - 1)
            {
                if(i + 2 < c.Count  && c[i+2] == 0)
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

            for(int x = 0; x < topic.Count; x++)
            {
                for(int y = x; y < topic.Count; y++)
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

            return new List<int>() { maximumSubject, items};
        }


        public static int beautifulTriplets(int d, List<int> arr)
        {
            int count = 0;

            for(int i  = 0; i < arr.Count - d; i++)
            {
                int arrValue = arr[i];

                if(arr.Contains(arrValue + d) && arr.Contains(arrValue +2 * d)) count++;
            }


            return count;
        }




    }
}
