﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resarvation.Models
{
    public class Student : Aspnetuser
    {
        public string Class { get; set; }
        public int ResCount { get; set; }

        //public int ReservationId { get; set; }
        //public Reservation Reservation { get; set; }
    }
}
