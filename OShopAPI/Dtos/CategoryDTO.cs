﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OShopAPI.Dtos
{
    public class CategoryDTO
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }
    }
}