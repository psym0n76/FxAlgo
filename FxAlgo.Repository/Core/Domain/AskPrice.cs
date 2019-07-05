﻿using System;

namespace FxAlgo.Repository
{
    public class AskPrice
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public DateTime DateStamp { get; set; }
    }
}
