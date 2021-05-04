using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
   public class UsersFollowingUnivercities:IDTOs
    {
        public int Id { get; set; }
        public string UnivercityName { get; set; }
        public int UnivercityId { get; set; }
        public string Image { get; set; }
        public int? StarCount { get; set; }
    }
}
