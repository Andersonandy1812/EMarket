using StockApp.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Domain.Entities
{
    public class User : AuditableBaseEntity
    {        
        public string Username { get; set; }
        
        public string Password { get; set; }
     
        public string Name { get; set; }
     
        public string Email { get; set; }
     
        public string Phone { get; set; }

        //navigation property
        public ICollection<Product> Products { get; set; }
    }
}
