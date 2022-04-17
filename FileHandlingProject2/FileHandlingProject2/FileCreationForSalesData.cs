using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingProject2
{
    public class FileCreationForSalesData
    {
        public void createFileWithSalesData(Dictionary<int, TotalSalesOfMobile> totalSalseOfMobile)
        {
            var writer = new StreamWriter(@"C:\\Users\\Bhanu Singh\\Documents\\PnonesSalesData.csv");
            foreach (var singleMobile in totalSalseOfMobile.Keys)
            {
                var line = string.Format(singleMobile + "," + totalSalseOfMobile[singleMobile].mobileName + "," + totalSalseOfMobile[singleMobile].totalPrice);
                writer.WriteLine(line);
                writer.Flush();
            }
            Console.WriteLine(@"Open C:\Users\Rohitdutt Parsai\Documents\sale_by_product.csv to view content");
        }
    }
}
