using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab2
{
    class IndexNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                Regex reg = new Regex(@"[0-9]{4}");
                string footageNumber = value.ToString();
                if (reg.IsMatch(footageNumber))
                {
                    return true;
                }
                else
                {
                    this.ErrorMessage = "Неверный формат метража";
                }
            }
            return false;
        }
    }
}
