using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Models
{
    public class Order
    {
        [BindNever]
        [Key]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        [Required(ErrorMessage ="Please enter your first name")]
        [Display(Name ="First name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your adresse")]
        [Display(Name = "Adresse name")]
        [StringLength(250)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please enter your zip code")]
        [Display(Name = "Zip code")]
        [StringLength(10, MinimumLength =4)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter your city")]
        [StringLength(50)]
        public string City { get; set; }
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your country")]
        [StringLength(50)]

        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "The email address is not entered in a correct format")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Phone number")]
        public string Email { get; set; }
        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlace { get; set; }

    }
}
