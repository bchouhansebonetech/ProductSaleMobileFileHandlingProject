using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject2
{
    public class MobileSalesDataDAO
    {
        public List<MobileSalesDataDO> getSalesDataFromFile(string currentFile)
        {
            List<MobileSalesDataDO> salesDataList = new List<MobileSalesDataDO>();
            string []  lines = System.IO.File.ReadAllLines(currentFile);
            foreach (string line in lines)
            {
                string [] mobileSalesValues = line.Split(',');
                MobileSalesDataDO mobileSalesData = new MobileSalesDataDO();    
                mobileSalesData.mobileId = Convert.ToInt32(mobileSalesValues[0]);
                mobileSalesData.mobileName = mobileSalesValues[1];
                mobileSalesData.mobilePrice = Convert.ToInt32(mobileSalesValues[2]);
                mobileSalesData.salesInADay = Convert.ToInt32(mobileSalesValues[3]);
                mobileSalesData.areaPincode = mobileSalesValues[4];
                mobileSalesData.salingDate = Convert.ToDateTime(mobileSalesValues[5]);
                salesDataList.Add(mobileSalesData);
            }
            return salesDataList;
        }
    }
}
