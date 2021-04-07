using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Comment:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Entry { get; set; }
        public int UnivercityId { get; set; }
    }
}
