using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _5
{
    class DataStorage : DataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }
        private List<RawDataItem> rawdata;
        private List<DataResult> debts;
        private List<DataResult> debtsResult;
        private char devider = '*';
        private DataStorage() { }
        
        private bool InitData(string datapath)
        {
            rawdata = new List<RawDataItem>();
            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        FIO = items[0].Trim(),
                        Group = items[1].Trim(),
                        Course = Convert.ToInt32(items[2].Trim()),
                        Debt = Convert.ToInt32(items[3].Trim())
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                FindDebt(datapath);
            }
            catch (IOException)
            {
                return false;
            }
            return true;
        }

        private void FindDebt(string datapath)
        {
            debts = new List<DataResult>();
            debtsResult = new List<DataResult>();

            StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] items = line.Split(devider);
                var item = new DataResult()
                {
                    Course = Convert.ToInt32(items[2].Trim()),
                    Debt = Convert.ToInt32(items[3].Trim())
                };
                debts.Add(item);
            }
            sr.Close();

            int sum = 0;
            // Поиск количества задолженностей по каждому курсу
            for (int i = 1; i <= 4; i++)
            {
                foreach (DataResult debt in debts)
                {
                    if (debt.Course == i && debt.Debt > 0)
                        sum += debt.Debt;
                }
                debtsResult.Add(new DataResult()
                {
                    Course = i,
                    Debt = sum
                });
                sum = 0;
            }
        }

        public static DataStorage DataCreator(string path)
        { 
            DataStorage d = new DataStorage();
            if (d.InitData(path))
                return d;
            else 
                return null;
        }
        public List<RawDataItem> GetRawData()
        {
            if (this.IsReady)
                return rawdata;
            else return null;
        }

        public List<DataResult> GetZadolgniki()
        {
            return debtsResult;
        }
    }
}

