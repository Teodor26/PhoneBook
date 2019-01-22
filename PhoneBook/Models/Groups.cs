using PhoneBook.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PhoneBook.Models
{
    public class Groups
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        [NonNumeric(ErrorMessage = "Не может начинаться с данного символа")]
        public string Name { get; set; }
    }
}