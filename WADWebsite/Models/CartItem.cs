using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WADWebsite.Models
{
    public class CartItem
    {
        
        public int FestivalID { get; set; }

        public string FestivalName { get; set; }

        public int OrderQuantity { get; set; }

        public string TicketType { get; set; }

        public decimal TicketPrice { get; set; }

        public string FestivalImage { get; set; }

        public DateTime OrderDate { get; set; }
    
    }
}
