﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockAccountManagement.StockManagement
{
    class StockManager
    {
        // read the stock report.
        public void StockReport(string filepath)
        {
            StreamReader read = null;
            double totalValue = 0;
            try
            {
                using (read = new StreamReader(filepath))
                {
                    var json = read.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    Console.WriteLine("Name\tNumber\tPrice\tStock Value");
                    foreach (var item in items)
                    {
                        totalValue += (item.NumberOfShare * item.SharePrice);
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t  " + "{3}", item.CompanyName, item.NumberOfShare, item.SharePrice, item.NumberOfShare * item.SharePrice);
                    }
                    Console.WriteLine("Total Stock Value:" + totalValue);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //// To close the file.
            finally
            {
                read.Close();
            }
        }
    }
}
