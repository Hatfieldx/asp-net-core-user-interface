using System;
using System.ComponentModel.DataAnnotations;

namespace lesson8.Validation_attributes
{
    public class RegDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null && value is DateTime regDate)
            {
                if (regDate < DateTime.Now)
                {
                    ErrorMessage = "Дата регистрации должна быть больше текущей";
                    return false;
                }

                else if (regDate.DayOfWeek == DayOfWeek.Saturday || regDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    ErrorMessage = "Дата регистрации не должна выпадать на выходной день";
                    return false;
                }
            }               
                
            return true;
        }
    }
}
