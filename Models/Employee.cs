using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int Zipcode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("IdentityUser")]
        public string IntentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }

}
