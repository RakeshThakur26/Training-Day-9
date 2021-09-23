using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollection
{
    class Consumer
    {
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }

        }

        private string name;
        public string Name {
            get { return name; }
            set { name = value; } 
        }
        private int totalUnits;
        public int TotalUnits {
            get { return totalUnits; }
            set {totalUnits = value; } 
        }

        private int totalAmount;
        public int TotalAmount {
            get {return totalAmount; }
            set {totalAmount = value; } 
        }

        private int costPerUnit;
        public int CostPerUnit {
            get { return costPerUnit; }
            set { costPerUnit = value; }
        }

        private int billNumber;
        public int BillNumber {
            get { return billNumber; }
            set { billNumber = value; }
        }

        private DateTime date;
        public DateTime Date {
            get {return date; }
            set {date = value; } 
        }
       
        
    }

}
