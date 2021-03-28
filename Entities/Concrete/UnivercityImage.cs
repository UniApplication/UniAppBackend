using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class UnivercityImage:IEntity
    {
        public int Id { get; set; }
        public int UnivercityId { get; set; }
        public string ImagePath { get; set; }
    }
}
