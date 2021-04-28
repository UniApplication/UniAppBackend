using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
   public class CommentDetailDto:IDTOs
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Entry { get; set; }
        public string UnivercityName { get; set; }
    }
}
