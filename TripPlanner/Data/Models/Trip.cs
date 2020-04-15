using System;



namespace  TripPlanner.Data
{
    public class  Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateCompleted { get; set; }

        public Trip()
        {
        }
        
        public Trip(int id, string name, string description, DateTime dateStarted, DateTime? dateCompleted)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.DateStarted = dateStarted;
            this.DateCompleted = dateCompleted; 
        }
    }


    
}