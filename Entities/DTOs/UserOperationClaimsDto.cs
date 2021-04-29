using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
   public class UserOperationClaimsDto:IDTOs
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string claimName { get; set; }
    }
}
