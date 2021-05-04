using CORE.Entities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
   public class UserFollowModelDto:IDTOs
    {
        public UserFollow userModel { get; set; }
        public bool isFollowing { get; set; }
    }
}
