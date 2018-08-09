using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
namespace LinkedList
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> head;
        public LinkedListNode<T> tail;
        public int Count { get; set; }

#region Method Add value to the end of LinkedList 
        public void Add(T value)
        {
            LinkedListNode<T> current = new LinkedListNode<T>(value);

            if(head == null)
            {
                head = current;
                tail = current;
            }
            else
            {
                tail.Next = current;
                tail = current;
            }

            Count++;
        }
        #endregion

#region Method Delete value from LinkedList
        public bool Remove(T value)
        {
            LinkedListNode<T> privious = null;
            LinkedListNode<T> current = head;
            
            while(current != null)
            {
                if(current.Value.Equals(value))
                {
                    if(privious != null)
                    {
                        privious.Next = current.Next;

                        if (current.Next == null)
                        {
                            tail = privious;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if(head == null)
                        {
                            tail = null;
                        }
                    }

                    Count--;
                    return true;
                }
                privious = current;
                current = current.Next;
            }
            return false;
        }
#endregion
    }
}
