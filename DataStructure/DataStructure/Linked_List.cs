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

        Node<Gtype> head = null;

        public void Add(Gtype data)
        {
            Node<Gtype> temp_node;

            // create new node with data
            Node<Gtype> node = new Node<Gtype>(data);


            if (head == null)
            {
                head = node;
                return;
            }
            else
            {
                temp_node = head;

                while (temp_node.next != null)
                    temp_node = temp_node.next;
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
                Node<Gtype> temp_node = head;
                Console.WriteLine(temp_node.val);
                while (temp_node.next != null)
                {
                    Console.WriteLine(temp_node.next.val);
                    temp_node = temp_node.next;
                }
            }
        }
        public Node<Gtype> InsertAtParticularPosition(int position, Gtype data)
        {

            Node<Gtype> newestNode = new Node<Gtype>(data);
            if (this.head == null)
            {
                return newestNode;
            }
            //Node Exchange

            Node<Gtype> prev = null;
            Node<Gtype> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }

    }
}
