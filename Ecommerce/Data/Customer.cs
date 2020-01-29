using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class Customer : IdentityUser
    {
        public List<Address> Addresses { get; set; }
    }
}
