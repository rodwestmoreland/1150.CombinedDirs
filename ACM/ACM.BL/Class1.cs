using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Program
    {
        static void Main()
        {
            IEnumerable<TheList> myList = new List<TheList>()
            {
                new TheList { ID = 1, Name = "Rod" },
                new TheList { ID = 2, Name = "Bob" }
            };

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(9));
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine(multiply(9,2));
            var query = myList.Where(x => x.Name.Length > 2).OrderBy(x => x.Name);
            
            foreach (var ele in query)
            {
                Console.WriteLine(ele.Name);
            }
        }
    }
    class TheList
    {
        public int ID;
        public string Name;
    }
}
