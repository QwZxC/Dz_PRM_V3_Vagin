using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZRPMV3
{
    internal class CorporateCustomer : Customer
    {
        private string contactName = "";
        private int creditRating;
        private int creditLimit;
        private Employee employee = new Employee();
    }
}
