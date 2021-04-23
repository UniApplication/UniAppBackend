using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
   public class PostDetail:IDTOs
    {
        public int Id { get; set; }
        public string UniName { get; set; }
        public string UniPost { get; set; }
    }
}
