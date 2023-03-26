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
    }
}
