using System.ComponentModel.DataAnnotations;

namespace AddressBook.Web.Models
{
    public class UpdateContactRequestModel
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}