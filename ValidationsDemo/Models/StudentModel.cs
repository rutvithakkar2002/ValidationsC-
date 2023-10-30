using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ValidationsDemo.Models
{
    public class StudentModel
    {
        public Guid StudentId
        {
            get;
            set;
        }
        [Required]
        public string FirstName
        {
            get;
            set;
        }
        [Required]
        public string LastName
        {
            get;
            set;
        }
        [Required]
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        [Required]
        public string Address
        {
            get;
            set;
        }
        [Required]
        public string ContactNo
        {
            get;
            set;
        }
        [Required]
        public string EmailId
        {
            get;
            set;
        }
        [Required]
        public string ConfirmEmail
        {
            get;
            set;
        }
        [Required]
        public string UserName
        {
            get;
            set;
        }
        [Required]
        public string Password
        {
            get;
            set;
        }
    }
}