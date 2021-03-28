using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Post:IEntity
    {
        public int Id { get; set; }
        public int UniId { get; set; }
        public string UniPost { get; set; }
    }
}
