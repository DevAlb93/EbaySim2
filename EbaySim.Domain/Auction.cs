using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySim.Domain
{
    public class Auction
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int StartingPrice { get; set; }
        public DateTime EndDate { get; set; }
    }
}
