﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HTActive.Entities
{
    public class ContentService
    {
        [Key]
        public int Id { get; set; }
        [StringLength(256)]
        public string ClaimName { get; set; }

        public List<RoleClaim> RoleClaims { get; set; }
    }
}
