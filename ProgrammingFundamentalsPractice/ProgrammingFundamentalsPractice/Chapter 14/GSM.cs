using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_14
{
    public class GSM : IGSM
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Garri: IGSM, IComparable<Garri>
    {
        public string Name { get; set; }
        IDictionary<string, string> aDHL = new SortedDictionary<string, string>();

        void DoIt<T, V, C>(T one, V two, C three)
        {
            string.Compare()
                IDictionary<string, int> words =
                new SortedDictionary<double, int>()
        }
        public int CompareTo(Garri? other)
        {
            // victory
            // Victory 

            // victory < Victory return -1
            // 0
            // 1
            return 0;
        }
    }

    public interface IGSM
    {
        string Name { get; set; }
    }

}
