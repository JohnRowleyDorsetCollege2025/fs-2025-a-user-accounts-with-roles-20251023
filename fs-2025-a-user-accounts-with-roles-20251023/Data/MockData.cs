using AppApp.Domain;
using Bogus;
using fs_2025_a_user_accounts_with_roles_20251023.Components.Pages;

namespace fs_user_accounts.Data;

public static class MockData
{
    public static List<Patient> Patients(int setNumberOfPatients = 50)
    {
        List<Patient> patients = new List<Patient>();

        var faker = new Faker<Patient>()
            .RuleFor(p => p.Id, f => Guid.NewGuid().ToString())
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.Email, (f, p) => f.Internet.Email(p.FirstName, p.LastName));

        for (int i = 0; i < setNumberOfPatients; i++)
        {

            patients.Add(faker.Generate());
        }

        return patients;

    }

    public static List<Hotel> Hotels(int count)
    {
        List<Hotel> hotels = new List<Hotel>();
        var faker = new Faker<Hotel>()
    .RuleFor(h => h.Name, f => $"{f.Company.CompanyName()} Hotel")
    .RuleFor(h => h.City, f => f.Address.City())
    .RuleFor(h => h.Stars, f => f.Random.Int(1, 5))
    .RuleFor(h => h.PricePerNight, f => f.Random.Decimal(50, 400))
    .RuleFor(h => h.HasWifi, f => f.Random.Bool())
    .RuleFor(h => h.HasBreakfast, f => f.Random.Bool());



        for (int i = 0; i < count; i++)
        {

            hotels.Add(faker.Generate());
        }

        return hotels;



    }


    public static List<Course> Courses(int count)
    {
        List<Course> courses = new List<Course>();

        var levels = new[] { "Beginner", "Intermediate", "Advanced" };

        var faker = new Faker<Course>()
            .RuleFor(c => c.Title, f => $"{f.Commerce.Department()} Fundamentals")
            .RuleFor(c => c.Instructor, f => f.Person.FullName)
            .RuleFor(c => c.DurationWeeks, f => f.Random.Int(4, 12))
            .RuleFor(c => c.Level, f => f.PickRandom(levels))
            .RuleFor(c => c.Price, f => f.Random.Decimal(50, 500));
        for (int i = 0; i < count; i++)
        {

            courses.Add(faker.Generate());
        }

        return courses;



    }
}

