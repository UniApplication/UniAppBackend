using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Univercity:IEntity
    {
        public int Id { get; set; }
        public string UnivercityName { get; set; }
        public string? UnivercityDescription { get; set; }
        public string? UnivercityRector { get; set; }
        public int CityId { get; set; }
        public int? StarCount { get; set; }

    }
}
