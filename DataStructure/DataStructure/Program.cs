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

            mylist.Add(56);
            mylist.Add(30);
            mylist.Add(70);
            mylist.Display();
        }
    }
}