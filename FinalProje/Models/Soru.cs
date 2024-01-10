using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using FinalProje.ViewModels;
using FinalProje.Models;

namespace FinalProje.Models
{
    public class Soru
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
    }
}
