using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandsOnCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Consumers ");
            int n = Convert.ToInt32(Console.ReadLine());
            string path1 = @"C:\Training\Training-Day-9\HandsOnCollection\HandsOnCollection\";
            Consumer[] consumer = new Consumer[n];
            
            FileStream fs = new FileStream(path1 + "ConsumerDetails.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);

            FileStream fs2 = new FileStream(path1+"bill.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sr2 = new StreamWriter(fs2);

            for (int i = 0; i < n; i++)
            {
                consumer[i] = new Consumer();
                Console.WriteLine("Enter Consumer " + (i+1) + " Details..");
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
                consumer[i].Date = DateTime.Now.AddDays(-1).AddMonths(+1);

                sr.WriteLine("************************");
                sr.WriteLine("Consumer name : " + consumer[i].Name);
                sr.WriteLine("Consumer Number : " + consumer[i].Number);
                sr.WriteLine("Total units : " + consumer[i].TotalUnits);
                sr.WriteLine("Cost per unit : " + consumer[i].CostPerUnit);
                sr.WriteLine();

                
            }
            sr.Close();

            List<Consumer> obj = new List<Consumer>();
            for (int i = 0; i < n; i++)
            {
                obj.Add(consumer[i]);
            }

            Console.WriteLine("\n Consumer Bill ");
            foreach (Consumer item in obj)
            {
                sr2.WriteLine("**************************************");
                sr2.WriteLine("Bill details of comsumer : " + item.Number);
                sr2.WriteLine("Bill number : " + item.BillNumber);
                sr2.WriteLine("Consumer number : " + item.Number);
                sr2.WriteLine("Total Amount : " + item.TotalAmount);
                sr2.WriteLine("Due date : " + item.Date);
                sr2.WriteLine();
                Console.WriteLine("Bill number : " + item.BillNumber + ", Consumer number : " + item.Number + ", Total Amount : " + item.TotalAmount + ", Due date : " + item.Date);
            }
            sr2.Close();

            Console.ReadKey();

        }
    }
}
