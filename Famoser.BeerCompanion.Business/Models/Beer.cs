﻿using System;

namespace Famoser.BeerCompanion.Business.Models
{
    public class Beer
    {
        public Guid Guid { get; set; }
        public DateTime Time { get; set; }
        public bool Posted { get; set; }
        public bool DeletePending { get; set; }
    }
}
