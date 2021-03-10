using DAL.Entities;

namespace Backend.Models
{
    public class PhoneBookEntryModel
    {
        public PhoneBookEntryModel(PhoneBookEntry phoneBookEntry)
        {
            Id = phoneBookEntry.Id;
            FirstName = phoneBookEntry.FirstName;
            LastName = phoneBookEntry.LastName;
            PhoneNumber = phoneBookEntry.PhoneNumber;
            Address = phoneBookEntry.Address;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

    }
}
