// See https://aka.ms/new-console-template for more information
using StockAccountManagement.StockManagement;

Console.WriteLine("Hello, World!");
const string STOCK_JSON = @"C:\Users\sanjay\source\repos\StockAccountManagement\StockAccountManagement\StockAccountManagement\StockManagement\Stock.json";
StockManager stockManager = new StockManager();
stockManager.StockReport(STOCK_JSON);