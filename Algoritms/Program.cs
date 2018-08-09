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
            LinkedListNode<int> first = new LinkedListNode<int>(5);
            LinkedListNode<int> second = new LinkedListNode<int>(10);
            first.Next = second;
            Console.WriteLine(first.Next.Value);
        }
    }
}
