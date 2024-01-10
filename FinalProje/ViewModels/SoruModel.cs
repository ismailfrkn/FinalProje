using System.ComponentModel.DataAnnotations;

namespace FinalProje.ViewModels
{
    public class SoruModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bir Soru Giriniz")]
        public string Question { get; set; }
        [Required(ErrorMessage = "1. Cevabı giriniz")]
        public string Answer1 { get; set; }
        [Required(ErrorMessage = "2. Cevabı giriniz")]
        public string Answer2 { get; set; }
        [Required(ErrorMessage = "3. Cevabı Giriniz")]
        public string Answer3 { get; set; }
        [Required(ErrorMessage = "4. Cevabı Giriniz")]
        public string Answer4 { get; set; }
    }
}
