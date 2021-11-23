using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Provider : Concept
    {
        [NotMapped]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Key]   // optional !
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        public string UserName { get; set; }
        public virtual IList<Product> Products { get; set; }

        public override string ToString()
        {
            return "Id: " + this.Id + "\n Name: " + this.UserName;
        }
        public override void GetDetails()
        {
            System.Console.WriteLine("Password:" + Password + " ConfirmPassword:" + ConfirmPassword + " IsApproved:" + IsApproved);

        }
    }
}
