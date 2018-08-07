using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class User_Informations
    {
        [Key]
        public int id { get; set; }

        //[Required(ErrorMessage = "Need User ID")]
        public string UID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(255)]
        [Display(Name = "First name")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "A phone number is required.")]
        [Display(Name = "Your contact number :")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number")]
        [RegularExpression(@"^([0-9]{9})$", ErrorMessage = "Invalid Phone Number, try 442567543.")]
        public string Phone { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [StringLength(255)]
        [Display(Name = "Postal Code")]
        public string Postal_Code { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(255)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Street is required")]
        [StringLength(255)]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "House number is required")]
        [StringLength(255)]
        [Display(Name = "House Number")]
        public string House_Number { get; set; }

        public User_Informations()
        {
            
        }

        public User_Informations(int id = 0, string UID = "", string Fname = "", string Lname = "", string Phone = "", string Email = "", string Postal_Code = "", string City = "", string Street = "", string House_Number = "")
        {
            this.id = id;
            this.UID = UID;
            this.Fname = Fname;
            this.Lname = Lname;
            this.Phone = Phone;
            this.Email = Email;
            this.Postal_Code = Postal_Code;
            this.City = City;
            this.Street = Street;
            this.House_Number = House_Number;
        }
    }
}