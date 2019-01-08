using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.Attributes
{
    public class NonNumericAttribute:ValidationAttribute
    {

        private int _number = 0;

        public delegate bool Validator(string value);

        private Dictionary<Validation, Validator> _validators =
            new Dictionary<Validation, Validator>();
        public override bool IsValid(object value)
        {
            if(value is string strValue)
            {
                if(!string.IsNullOrEmpty(value.ToString()))
                {
                    if (strValue[0] != '1')
                        return true;
                }
            }          

            return false;
        }

        public NonNumericAttribute(int number)
        { 
            number = _number;


        }


        public enum Validation
        {
            number1 = 0,
            number2,
            number3,
            number4,
            number5,
            number6,
            number7,
            number8,
            number9,
            letter = 'ё',
            letter1 = 'ь',
            letter2 = 'ъ'

        }
    }
}