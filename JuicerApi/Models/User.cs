using System;

namespace JuicerApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
