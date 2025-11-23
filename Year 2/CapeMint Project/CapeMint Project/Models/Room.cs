using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapeMint_Project.Models
{
    public class Room
    {
        public int? roomTypeId { get; set; }

        public string roomTypeName { get; set; }

        public int roomPrice { get; set; }
        public string roomFeatures { get; set; }

    }
}