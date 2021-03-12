﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resarvation.Models
{
    public class Reservation
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Cause { get; set; }

        public Apprenant Apprenant { get; set; }
        public TypeReservation TypeReservation { get; set; }
    }
}
