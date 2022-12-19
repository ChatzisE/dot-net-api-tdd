using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures;

public static class UsersFixture
{
    public static List<User> GetTestUsers() =>
        new()
        {
            new()
            {
                Id = 1,
                Name = "Nikos Koukos",
                Address = new()
                {
                    Street = "Eleftherias",
                    City = "Glyfada",
                    ZipCode = "17764"
                },
                Email = "nikoskoukos@gmail.com"
            },
            new()
            {
                Id = 1,
                Name = "Nikos Koukos",
                Address = new()
                {
                    Street = "Eleftherias",
                    City = "Glyfada",
                    ZipCode = "17764"
                },
                Email = "nikoskoukos@gmail.com"
            },
            new()
            {
                Id = 1,
                Name = "Nikos Koukos",
                Address = new()
                {
                    Street = "Eleftherias",
                    City = "Glyfada",
                    ZipCode = "17764"
                },
                Email = "nikoskoukos@gmail.com"
            }
        };
}