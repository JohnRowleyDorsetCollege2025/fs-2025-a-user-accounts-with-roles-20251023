namespace AppApp.Domain
{
    public class Patient
    {
        public string Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

    }

    public class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Stars { get; set; }
        public decimal PricePerNight { get; set; }
        public bool HasWifi { get; set; }
        public bool HasBreakfast { get; set; }
    }

    public class Course
    {
        public string Title { get; set; }
        public string Instructor { get; set; }
        public int DurationWeeks { get; set; }
        public string Level { get; set; } // e.g. Beginner, Intermediate, Advanced
        public decimal Price { get; set; }
    }
}
