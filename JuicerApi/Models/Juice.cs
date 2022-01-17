using System;

namespace JuicerApi.Models
{
    public class Juice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CalorieCount { get; set; }
        public int Classification { get; set; }
        public string Image { get; set; }
        public int ServingSize { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

    }
}
