using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoTreats.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required()]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required()]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required()]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime LastTreatDate { get; set; }
        public DateTime NextTreatDate { get; set; }

    }
}