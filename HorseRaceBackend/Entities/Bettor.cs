﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceBackend.Entities
{
    public class Bettor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Bet { get; set; }
        public int? HorseId { get; set; }
    }
}
