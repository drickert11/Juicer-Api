using System;

namespace JuicerApi.Models
{
    public class Ingredient
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public int CalorieCount { get; set; }
        public string Image { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

    }
}
