using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZRPMV3
{
    internal class Order
    {
        private DateTime dateResived;
        private bool isPrepaid;
        private string number = "";
        private int money;
        private List<OrderLine> orderLines = new List<OrderLine>();
        private Customer customer = new Customer();
    }
}
