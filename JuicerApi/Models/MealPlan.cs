using System;

namespace JuicerApi.Models
{
    public class MealPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CalorieCount { get; set; }
        public int days { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int CopyReferenceId { get; set; }
    }
}
