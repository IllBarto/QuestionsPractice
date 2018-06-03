using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewPractice.Lock
{
    class ListOperation<T>
    {
        public ICollection<T> list;
        public ListOperation(ICollection<T> list)
        {
            this.list = list;
        }
        private readonly object o = new object();

        public void AddElement(T element)
        {
            lock (list)
            {
                list.Add(element);
                Thread.Sleep(10000);
                list.ToList().ForEach(x => Console.Write(x + "  "));
                Console.WriteLine();
            }
        }

        public void RemoveElement(T element)
        {
            //lock (list)
            //{
                if ((list.Where(x => x.Equals(element)).ToList()).Count() == 0) throw new InvalidOperationException();

                list = list.Where(x => !x.Equals(element)).ToList();
                Thread.Sleep(10000);
                list.ToList().ForEach(x => Console.Write(x + "  "));
                Console.WriteLine();
            //}
        }

        public void Display()
        {
            list.ToList().ForEach(x => Console.Write(x + "  "));
        }
    }
}
