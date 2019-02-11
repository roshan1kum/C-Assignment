using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class query
    {
        List<string> arr = new List<string>();
        public query(List<string> arr)
        {
            this.arr = arr;
        }
        public void plural()
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i] + "s");
            }
        }
        //public IEnumerable<string> lengthofCharacter(int n)
        //{
        //    var len = from v in array
        //              where v.Length = n
        //              select v;
        //}
        public void printList()
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
