using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_List<int> mylist = new Linked_List<int>();

            mylist.AppendLinked_List(56);
            mylist.AppendLinked_List (30);
            mylist.AppendLinked_List(70);
            mylist.Display();
        }
    }
}