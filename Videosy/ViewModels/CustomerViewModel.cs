using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videosy.Models;

namespace Videosy.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }

        public string Title { get {
                if (Customer != null && Customer.Id != 0)
                    return "Edit";

                return "New";
            } }
    }
}