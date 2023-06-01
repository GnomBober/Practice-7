using practice7;
using System.Xml.Linq;

namespace practice7
{
    internal class Structure
    {
        Edition head;
        Edition tail;
        public void Add(Edition value)
        {;
            if (head == null)
                head = value;
            else
            {
                tail.Next = value;
                value.Prev = tail;
            }
            tail = value;
        }
        public void Delete(int id)
        {
            Edition temp = head;
            for (int i = 0; i < id; i++)
            {
                temp = temp.Next;
            }
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }
        public void GetSingleInfo(int id)
        {
            Edition temp = head;
            for (int i = 0; i < id; i++)
            {
                temp = temp.Next;
            }
            temp.GetInfo();
        }
        public void GetAllInfo()
        {
            for(Edition temp = head; temp.Next == null;)
            {
                temp.GetInfo() ;
            }
        }
    }
}