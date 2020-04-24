using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    public class Customer
    {
      [Key]
      public int Id { get; set; }
      public string Name { get; set; }

      [ForeignKey("IndentityUser")]
      public string IdeneityUserId { get; set; }
      public IdentityUser IdentityUser { get; set; }

        
      
    }
    
    
}
