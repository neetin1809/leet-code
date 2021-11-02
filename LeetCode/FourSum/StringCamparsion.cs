using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
   // https://leetcode.com/problems/find-the-difference/
    public   class StringCamparsion
    {
        public StringCamparsion() { }

        public char FindTheDifference(string s, string t)
        {
            t =  String.Format($"{s}{t}");
            int res = 0;

            for (int i=0; i < t.Length; i++)
            {
                res ^= (int)t[i];
            }
            return (char)res;
        }

    }
    //https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
    public class RemoveDuplicatesFromString
    {
        public string RemoveDuplicates(string S)
        {
            string current = S;
            while (!string.IsNullOrEmpty(FindDuplicates(current)))
            {
                current = current.Replace(FindDuplicates(current), "");
            }
            return current;
        }

        public string FindDuplicates(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    return str.Substring(i, 2);
                }
            }
            return "";
        }
    }
        //https://leetcode.com/problems/height-checker/
        public class HeightCheckerSolution
        {
            public int HeightChecker(int[] heights)
            {

                int move = 0;
                int length = heights.Length;
            int[] sorted = heights.OrderBy(x=>x).ToArray();
                for (int i = 0; i < length; i++)
                {
                    if((sorted[i] != heights[i ]))
                    {
                        move++;
                    }
                }
                
                return move;

            }


    }
        //https://leetcode.com/problems/student-attendance-record-i/discuss/380159/6-Lines-concise-C%2B%2B-Solution.-O(N)
        public class RecordCamparsion
    {
        public bool CHeckRecord(string s)
        {
            int A = 0, L = 0;
            for (int i = 0; i < s.Length; i++)
            {
                A = (s[i] == 'A')?A+1:A;
                L = (s[i] == 'L') ? L + 1 : L;
                if (A > 1 || L > 2) return false;
            }
            return true;
        }
    }

    //https://leetcode.com/problems/subdomain-visit-count/
    public class SubdomainVisit
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            IList<String> subdomains = new List<string>();
            Dictionary<string, int> portDomain = new Dictionary<string, int>();
            // 9001 discuss.leetcode.com
            //"9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com"
            //"900 google.mail.com", "50 yahoo.com"
            //950 com, 900 google.mail.com, 900 gmail.com,50 yahoo.com
            foreach (string domain in cpdomains)
            {
                var list = Getdomains(domain, ref portDomain);
                ((List<string>)subdomains).AddRange(list);
            }

             
            if(cpdomains.Length > 1)
            {
                List<KeyValuePair<int, string>> dictKeys = new List<KeyValuePair<int, string>>();

                dictKeys = Enumerable.Range(0, subdomains.Count).
                    Select(i => new KeyValuePair<int, string>(Convert.ToInt32(subdomains[i].Split(' ')[0]), subdomains[i].Split(' ')[1])).ToList();

                subdomains = new List<string>();
                subdomains = (from d in dictKeys
                                  group d by d.Value into dp
                                  select String.Format("{0} {1}", dp.Sum(d => d.Key), dp.Key)).ToList();

                //dictKeys.GroupBy(x => x.Value).Select(x=> new KeyValuePair<int,string>((int)x.Sum(d=>d.Key),d.v))
                /*foreach (KeyValuePair<int,string> item in dictKeys.GroupBy(x=>x.Value).Select(g => g.),  x =>x.First().Value))
                {
                    var tempList = dictKeys.Where(x => x.Value == item).Select(x =>x.Key); 
                    int sum = tempList.Sum();
                    subdomains.Add(string.Format("{0} {1}", sum, item));
                }*/

            }
            return subdomains;

        }

        private IList<string> Getdomains(string cpdomain,ref Dictionary<string,int> portDomain)
        {
            IList<String> subdomains = new List<string>() { cpdomain };
            string[] cpDomain = cpdomain.Split(' ');
            string subdomain = cpDomain[1];
            while (subdomain.Contains('.'))
            {
                int count = 0;
                subdomain = subdomain.Substring(subdomain.IndexOf('.') + 1);
                subdomains.Add(String.Format("{0} {1}",cpDomain[0], subdomain));
                if (portDomain.TryGetValue(subdomain, out count))
                {
                    portDomain[subdomain] = Convert.ToInt32(cpDomain[0]) + count;
                }
                else
                {
                    portDomain.Add(subdomain, Convert.ToInt32(cpDomain[0]));
                }
            }
            return subdomains;
        }
    }

    //https://leetcode.com/problems/sqrtx/
    public class SquareRoot
    {
        public int MySqrt(int x)
        {
            var num = 0;

            while (num * num <= x)
            {
                num += 1;
            }

            return --num;
        }
    }

    //https://leetcode.com/problems/valid-anagram/
    public class Anagram
    {
        public bool IsAnagram(string s, string t)
        {

            // s.GroupBy(c => c).Select(c => srcCount.Add(c.Key, c.Count));
            if (s.Length != t.Length)
                return false;
            var counts = s.GroupBy(c => c).OrderBy(c => c.Key).Select(g => new { Char = g.Key, Count = g.Count() });
            foreach (var item in s.GroupBy(c => c).OrderBy(c => c.Key))
            {
                if (t.ToCharArray().Where(c => c == item.Key).Count() != item.Count())
                    return false;

            }

            return String.Join("", s.ToCharArray().OrderBy(c => c)) == String.Join("", t.ToCharArray().OrderBy(c => c));
           // return true;
        }
    }

    //https://leetcode.com/problems/valid-parentheses/submissions/
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            Stack<Char> st = new Stack<char>();

            foreach (Char item in s)
            {
                if (item == '(')
                    st.Push(')');
                else if (item == '[')
                    st.Push(']');
                else if (item == '{')
                    st.Push('}');
                else if (st.Count != 0 && item == st.Peek())
                    st.Pop();
                else
                    return false;
            }

            return st.Count == 0; 
        }
    }

    //https://leetcode.com/problems/distance-between-bus-stops/
    public class DistanceBetweenBusStops_V1
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            /*if (start == destination) return 0;
            var first = start < destination ? start : destination;
            var second = first == start ? destination : start;
            var sum = distance.Sum();
            var sum1 = distance.Where((x, i) => i >= first && i < second).Sum();
            var sum2 = sum - sum1;
            return Math.Min(sum1, sum2);*/
            int sum1 = 0, sum2 = 0, sum = 0;
            for (int i = 0; i < distance.Length; i++)
            {
                sum = sum + distance[i];

                //When start is less then dest
                if (i == start && i >= destination)
                    sum1 += distance[i];

                //When destination is greater then start
                if (i == destination && i <= start)
                    sum2 += distance[i];
            }
            
            return sum1>sum2?sum2: sum1;
        }
    }
    //https://leetcode.com/problems/shortest-distance-to-a-character/discuss/379816/Readable-C-O(n)-Solution
    public class ShortestDistance_ToA_Character
    {
        public int[] ShortestToCHar(string S, char C)
        {
            int[] answers = new int[S.Length];
            //collect the indexes of character to search
            var list = S.Select((st, i) => i).Where(i => S[i] == C).ToArray();
            int index = 0;

            for (int i = 0; i < S.Length; i++)
            {
                //Taking the Measure from Front
                int diff1 = Math.Abs(i - list[index]);
                //Taking the distance from End
                int diff2 = Math.Abs(index + 1 < list.Length ? i - list[index + 1] : int.MaxValue);

                if(diff1 < diff2)
                {
                    answers[i] = diff1;
                }
                else
                {
                    answers[i] = diff2;
                    index++;
                }
            }

            return answers;
        }
    }
}
