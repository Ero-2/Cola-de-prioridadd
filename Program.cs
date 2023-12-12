using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prioridad_TT
{
    internal class Program
    {
        public class PriorityQueue<T> where T : IComparable<T>
        {
            private List<T> elements = new List<T>();

            public int Count => elements.Count;

            // Adds an element to the priority queue
            public void Enqueue(T element)
            {
                elements.Add(element);
                elements.Sort(); // Sorts the list to maintain priority
            }

            // Removes and returns the element with the highest priority
            public T Dequeue()
            {
                if (elements.Count == 0)
                {
                   return default(T);
                }

                T element = elements[0];
                elements.RemoveAt(0);
                return element;
            }

        }

        static void Main(string[] args)
        {
            // Create a priority queue with integers
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();


            // Allow the user to enter elements
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(2);
            priorityQueue.Enqueue(8);
            priorityQueue.Enqueue(1);


            Console.WriteLine("Elements in the priority queue:");

            // Display the elements in priority order (from least to greatest)
            while (priorityQueue.Count > 0)
            {
                int element = priorityQueue.Dequeue();
                Console.WriteLine(element);
            }


            Console.ReadKey();
        }
    }
}
