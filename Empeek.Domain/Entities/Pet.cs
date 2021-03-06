﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.Domain.Entities
{
    [Table("tblPet")]
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
