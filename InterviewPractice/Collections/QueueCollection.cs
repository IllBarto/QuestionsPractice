using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Collections
{
    class QueueCollection
    {
        Queue<string> names = new Queue<string>();
        //Queue names = new Queue();

        public void InitialFillQueue()
        {
            names.Enqueue("John");
            names.Enqueue("Garry");
            names.Enqueue("Bobby");
            names.Enqueue("Kaile");
        }

        public Queue<string> GetQueueNames()
        {
            return names;
        }

        public void AddItemInNames(string name)
        {
            names.Enqueue(name);
        }
        //public void AddItemInNames(int name)
        //{
        //    names.Enqueue(name);
        //}

        public void WriteAllNames()
        {
            foreach (var item in names)
            {
                Console.WriteLine("\t- "+item);
            }
        }

        public void RemoveOldest()
        {
            names.Dequeue();
        }
        
        public string GetTheOldest()
        {
            return names.Peek();
        }
    }
}
