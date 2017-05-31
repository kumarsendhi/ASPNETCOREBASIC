﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public enum CuisineType
    {
        None,
        Italian,
        French,
        Japanese,
        American
    }
    public class Restaurants
    {
        public int Id { get; set; }

        [Required,MaxLength(80)]
        [Display(Name="Restaurant Name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
