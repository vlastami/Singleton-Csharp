using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Code Example
            MySingleton mySingleton = MySingleton.Instance;
            mySingleton.DoSomething();
        }
    }

    public class MySingleton
    {
        private static MySingleton instance = null;
        private MySingleton()
        {

        }
        public static MySingleton Instance
        {
            get { 
                if (instance == null)
                {
                    instance = new MySingleton();
                }
                
                return instance; }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton class code has been called");
            Console.ReadLine();
        }
    }
}