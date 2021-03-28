using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class UserFollow:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UniId { get; set; }
    }
}
