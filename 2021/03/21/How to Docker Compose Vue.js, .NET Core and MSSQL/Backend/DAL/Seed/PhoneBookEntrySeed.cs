using DAL.Entities;
using System.Collections.Generic;

namespace DAL.Seed
{
    public class PhoneBookEntrySeed
    {
        public PhoneBookEntrySeed()
        {
            PhoneBookEntries = new List<PhoneBookEntry>()
            {
                new PhoneBookEntry()
                {
                    Id = 1,
                    FirstName = "Seneca",
                    LastName = "Farhana",
                    PhoneNumber = "+35943815315",
                    Address = "Emilia-Romagna, Italy",
                },
                new PhoneBookEntry()
                {
                    Id = 2,
                    FirstName = "Dorofey",
                    LastName = "Juraj",
                    PhoneNumber = "+359 43 985 602",
                    Address = "	Ingushetia, Russia",
                },
                new PhoneBookEntry()
                {
                    Id = 3,
                    FirstName = "Feidhlimidh",
                    LastName = "Benigna",
                    PhoneNumber = "+359 43 061 126",
                    Address = "Ireland",
                },
                new PhoneBookEntry()
                {
                    Id = 4,
                    FirstName = "Katla",
                    LastName = "Gumarich",
                    PhoneNumber = "+359 437 695 17",
                    Address = "Icelandic",
                },
                new PhoneBookEntry()
                {
                    Id = 5,
                    FirstName = "Gregor",
                    LastName = "Eugène",
                    PhoneNumber = "+359 48 083 694",
                    Address = "Austria",
                },
                new PhoneBookEntry()
                {
                    Id = 6,
                    FirstName = "Afon",
                    LastName = "Joetta",
                    PhoneNumber = "+359 437 099 56",
                    Address = "Ceredigion, Wales, United Kingdom",
                },
                new PhoneBookEntry()
                {
                    Id = 7,
                    FirstName = "Henrik",
                    LastName = "Liudevit",
                    PhoneNumber = "+359 43 049 097",
                    Address = "Baden-Württemberg, Germany",
                },
                new PhoneBookEntry()
                {
                    Id = 8,
                    FirstName = "Sachin",
                    LastName = "Esteve",
                    PhoneNumber = "+359 98 568 6606",
                    Address = "Gujarat, India",
                },
                new PhoneBookEntry()
                {
                    Id = 9,
                    FirstName = "Filipa",
                    LastName = "Cillian",
                    PhoneNumber = "+359 89 825 1635",
                    Address = "Brazil",
                },
                new PhoneBookEntry()
                {
                    Id = 10,
                    FirstName = "Crescenzo",
                    LastName = "Stine",
                    PhoneNumber = "+359 43 862 362",
                    Address = "Lombardy, Italy",
                },
            };
        }

        public List<PhoneBookEntry> PhoneBookEntries { get; set; }
    }
}
