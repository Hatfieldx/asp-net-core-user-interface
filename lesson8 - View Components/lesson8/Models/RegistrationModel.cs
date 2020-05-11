using System;
using System.ComponentModel.DataAnnotations;
using lesson8.Validation_attributes;

namespace lesson8.Models
{
    public class RegistrationModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Имя Фамилия")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Name { get; set; }
        
        [Display(Name = "Почтовый адрес")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "адрес должен быть в формате xx@xx.xx")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Email { get; set; }
        
        [RegDate]
        [DataType(DataType.Date, ErrorMessage = "Необходимо ввести корректную дату")]
        [Display(Name = "Дата регитсрации")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public DateTime RegDate { get; set; }

        public string Product { get; set; }
    }
}
