﻿using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class City:IEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }
}
