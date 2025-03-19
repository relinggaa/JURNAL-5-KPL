using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300107
{
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDate;
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDate = new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputDate.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
           for(int i=0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + i + 1 + " berisi" + " "+storedData[i] + " "+"yang disimpan  pada waktu  " + inputDate[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<double> db = new SimpleDataBase<double>();
            Console.WriteLine("Masukan 1:");
            double aa = double.Parse(Console.ReadLine());
            db.AddNewData(aa);
            Console.WriteLine("Masukan 2:");
            double bb = double.Parse(Console.ReadLine());
            db.AddNewData(bb);
            Console.WriteLine("Masukan 3:");
            double cc = double.Parse(Console.ReadLine());
            db.AddNewData(cc);
            db.PrintAllData();
        }
    }
}
