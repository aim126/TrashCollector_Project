using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollectorProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Zip Code")]
        public int Zipcode { get; set; }
        [Display(Name = "First Name")]
        public string  FirstName { get; set;  }
        [Display(Name = "Last Name")]
        public string  LastName  { get; set;  }
        [Display(Name = " City")]
        public string  City      { get; set;  }
        [Display(Name ="State")]
        public string  State     { get; set;  }
        [Display(Name = "Street Name")]
        public string  StreetName { get; set; }
        [Display(Name = "Email Address")]
        public string  EmailAddress { get; set; }
        [Display(Name = "Day For Pickup")]
        public string DayForPickUp { get; set; }
        [Display(Name =  " Start Suspension Date")]
        public DateTime StartSuspensionDate { get; set; }
        [Display(Name = "End Suspension Date")]
        public DateTime EndSuspensionDate { get; set; }
        [Display(Name =  "Extra Pickup Date")]
        public DateTime ExtraPickUp  { get; set; }
       
        [ForeignKey("IndentityUser")]
        public string IdeneityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
     // var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
     // customer.IdentityUserId = userId;
     // _context.Add(customer);
     // _context.SaveChanges();

     //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
     //   var customer = _context.Customers.Where(c => c.IdentityUserId ==
     //   userId).SingleOrDefault();
    
    
    
}
