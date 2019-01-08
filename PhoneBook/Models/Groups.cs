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
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [NonNumeric(ErrorMessage = "Не может начинаться с 1")]
        public string Name { get; set; }
    }
}