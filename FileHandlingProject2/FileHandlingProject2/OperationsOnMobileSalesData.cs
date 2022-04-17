using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject2
{
    public class OperationsOnMobileSalesData
    {
        public Dictionary<int, TotalSalesOfMobile> getTotolSalesOfMobile(List<MobileSalesDataDO> mobileSalesDataDOs)
        {
            Dictionary<int, TotalSalesOfMobile> totalSalseOfMobile = new Dictionary<int, TotalSalesOfMobile>();

            foreach (MobileSalesDataDO mobileSalesDataDO in mobileSalesDataDOs)
            {

                if (totalSalseOfMobile.ContainsKey(mobileSalesDataDO.mobileId))
                {
                    totalSalseOfMobile[mobileSalesDataDO.mobileId].totalPrice += mobileSalesDataDO.mobilePrice;
                }
                else
                {
                    TotalSalesOfMobile totalSalesOfMobile = new TotalSalesOfMobile();
                    totalSalesOfMobile.mobileId = mobileSalesDataDO.mobileId;
                    totalSalesOfMobile.mobileName = mobileSalesDataDO.mobileName;
                    totalSalesOfMobile.totalPrice = mobileSalesDataDO.mobilePrice;

                    totalSalseOfMobile[mobileSalesDataDO.mobileId] = totalSalesOfMobile;
                }
            }
            return totalSalseOfMobile;
        }
    }
}
