using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
   public class UnivercityDetailDto:IDTOs
    {
        public int UnivercityId { get; set; }
        public string UnivercityName { get; set; }
        public string UnivercityDescription { get; set; }
        public string UnivercityRector { get; set; }
        public int? StarCount { get; set; }
        public string CityName { get; set; }
        public string? UnivercityImage { get; set; }
    }
}
