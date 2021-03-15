using System;
using System.ComponentModel.DataAnnotations;

namespace Drinks.Models
{
    public class Cocktail
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Glass {get ; set; }

        //[DataType(DataType.ImageUrl)] Would like to add images
        public string Category { get; set; }

        //Eventually change this to a list 
        public string Ingredients { get; set; }

        public string Garnish{ get; set; }

        public string Preparation { get; set; }
    }
}