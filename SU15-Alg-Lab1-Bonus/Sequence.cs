using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SU15_Alg_Lab1_Bonus
{
    public class Sequence : IEnumerable<int>
    {
        private List<int> Numbers { get; set; }
        public int Count => Numbers.Count;

        public Sequence()
        {
            Numbers = new List<int>();
        }

        public void Add(int num)
        {
            Numbers.Add(num);
        }

        public int this[int index]
        {
            get { return Numbers[index]; }
            set { Numbers[index] = value; }
        }

        public void Add(IEnumerable<int> nums)
        {
            Numbers.AddRange(nums);
        }

        public List<int> ToList()
        {
            return Numbers.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return Numbers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(" ", Numbers);
        }

        public override bool Equals(object obj)
        {
            if (obj is Sequence)
            {
                return ToString() == obj.ToString();
            }

            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}