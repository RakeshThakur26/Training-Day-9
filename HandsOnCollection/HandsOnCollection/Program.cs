using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Consumers ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            Consumer[] consumer = new Consumer[n];

            for (int i = 0; i < n; i++)
            {
                consumer[i] = new Consumer();
                Console.WriteLine("Enter Consumer " + i + " Details..");
                Console.WriteLine("***************");
                Console.WriteLine("Enter consumer number : ");
                consumer[i].Number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter consumer Name : ");
                consumer[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Total Units : ");
                consumer[i].TotalUnits = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Cost per Unit : ");
                consumer[i].CostPerUnit = Convert.ToInt32(Console.ReadLine());

                consumer[i].TotalAmount = consumer[i].TotalUnits * consumer[i].CostPerUnit;
                Console.WriteLine();
                Random r = new Random();

                consumer[i].BillNumber = r.Next(100);
                consumer[i].Date = DateTime.Now;
            }

            List<Consumer> obj = new List<Consumer>();
            for (int i = 0; i < n; i++)
            {
                obj.Add(consumer[i]);
            }

            foreach (Consumer item in obj)
            {
                Console.WriteLine("Consumer Bill : ");
                Console.WriteLine("Bill number : " + item.BillNumber + ", Consumer number : " + item.Number + ", Total Amount : " + item.TotalAmount + ", Due date : " + item.Date);
            }

            Console.ReadKey();

        }
    }
}
