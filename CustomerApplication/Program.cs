using System;
using System.Security.Cryptography.X509Certificates;

namespace CustomerApplication
{
    delegate void MyCustomdelegate();
    delegate void mycustomerdelegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi World!");

            MyCustomdelegate mycustomdel= delegate ()
            {
                Console.WriteLine("Inside custom delegate");
            };

            MyCustomdelegate mycustomdel2 = new MyCustomdelegate(updateapi);

            MyCustomdelegate del = () => Console.WriteLine("Inside custom delegate");

           // mycustomerdelegate del = x => x * x;
        }

        private static void updateapi()
        {


        }
    }

    public class customer
    {
        public void AddCustomer()
        {
            throw new NotImplementedException();
        }
             
    }

}
