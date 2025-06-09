using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject
{
    public class Order
    {
        public int OrderId { get; set; }
        public double TotalPrice { get; set; }

        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public Employee Employee { get; set; }
        public List<Order_Product> OrderProducts { get; set; }
    }
}
