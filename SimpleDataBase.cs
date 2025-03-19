using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300016
{
    class SimpleDataBase<T>
    {
        // Variabel bertipe data generic T agar bisa menerima input data dari variable apapun

        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi: " + storedData[i] + " yang disimpan pada waktu UTC: " + inputDates[i]);
            }

        }
    }
}
