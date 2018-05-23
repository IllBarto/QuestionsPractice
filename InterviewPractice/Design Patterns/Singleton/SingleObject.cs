using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.Design_Patterns.Singleton
{
    class SingleObject
    {
        private static SingleObject instance;

        private SingleObject()
        {

        }

        public static SingleObject GetInstance()
        {
            if (instance == null)
                instance = new SingleObject();

            return instance;
        }

        public void WriteMessage(string mess)
        {
            Console.WriteLine(mess);
        }
    }
}
