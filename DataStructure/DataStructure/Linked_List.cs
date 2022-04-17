using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Linked_List<Gtype>
    {

        // variable
        // store the count in tenp node

        Node<Gtype> head = null;

        public void Add(Gtype data)
        {
             // variable
            // store the count in tenp node

            Node<Gtype> temp_node;

            // create new node with data
            Node<Gtype> node = new Node<Gtype>(data);

            // there is no node
            if (head == null)
            {
            // if there is no element so first one is head
                head = node;
                return;
             
            }
            else
            {
                //count start from head
                temp_node = head;
                // check for null
                while (temp_node.next != null)
                    temp_node = temp_node.next;
                 // adding the node to next variable      
                temp_node.next = node;
            }
        }

        public void Display()
        {

            if (head is null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                 //created temp variable and the node display start from head
                Node<Gtype> temp_node = head;
                //displaying head as we had head value
                Console.WriteLine(temp_node.val);
                while (temp_node.next != null)
                {
                    Console.WriteLine(temp_node.next.val);
                    temp_node = temp_node.next;
                }
            }
        }
    }
}


