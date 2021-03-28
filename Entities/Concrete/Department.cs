using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Department:IEntity
    {
        public int Id { get; set; }
        public int UniId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int MinScore { get; set; }
    }
}
