using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "C:\\Users\\Bhanu Singh\\Documents\\PnonesSalesData.csv";
            MobileSalesDataDAO dao = new MobileSalesDataDAO();
            var salesDataList = dao.getSalesDataFromFile(filePath);
            OperationsOnMobileSalesData operationsOnMobileSalesData = new OperationsOnMobileSalesData();
            Dictionary<int, TotalSalesOfMobile> totalSalesData = operationsOnMobileSalesData.getTotolSalesOfMobile(salesDataList);
            FileCreationForSalesData fileCreationForSalesData = new FileCreationForSalesData();
            fileCreationForSalesData.createFileWithSalesData(totalSalesData);
        }
    }
}
