using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(5);
            list.Add(15);
            list.Add(25);

            list.Remove(15);


            Console.WriteLine(list.Count);
            Console.WriteLine(list.head.Value);
            Console.WriteLine(list.tail.Value);
        }
    }
}
