using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    // to add to BST node
    // need a remove BST node
    class BinarySearchTree
    {
        // memeber varriables
        
        

        //constructor
        public BinarySearchTree()
        {
            
        }

        //methods
        public void traverse()
        {
            if (left != null)
            {
                left.traverse();
            }
            Console.WriteLine(this.value);
            if (right != null)
            {
                right.traverse();
            }

            public void insert(int value)
            {
                if (value <= Data)
                {
                    if (left == null)
                    {
                        left = new Node(value);
                    }
                    else
                    {
                        left.insert(value);
                    }
                    else
                    {

                    }
                }
            }
            public void printInOrder()
            {

            }

        }
    }

}




