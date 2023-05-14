using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Prolems
{
    public class EasyProblemsSolve
    {
        public static string happyLadybugs(string b)
        {
            var ladybugs = b.ToArray();
            var ladybugsSet = b;

            if (!ladybugsSet.Contains("_"))
            {
                for (int i = 0; i < ladybugs.Length-1; i++)
                {
                    if (i == 0 ) continue;
                    
                    if ( ladybugs[i-1] != ladybugs[i] &&   ladybugs[i] != ladybugs[i + 1])
                    {
                        return "NO";
                    }
                }

                if(ladybugs.Length == 1 || ladybugs[ladybugs.Length - 2] != ladybugs[ladybugs.Length - 1])
                {
                    return "NO";
                }
                return "YES";
            }
            else
            {
                foreach (var ladybug in ladybugsSet.ToArray())
                {
                    if (ladybug != '_')
                    {
                        if (ladybugs.Count(color => color == ladybug) == 1)
                        {
                            return "NO";
                        }
                    }
                }
                return "YES";
            }
        }
    }
}
