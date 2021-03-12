﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resarvation.Models
{
    public class ReservApprenantViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        //public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Cause { get; set; }
        //public string SearchString { get; set; }
        public string TypeReservation { get; set; }
    }
}
