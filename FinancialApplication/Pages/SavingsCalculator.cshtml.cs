using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FinancialApplication.Pages
{
    public class SavingsCalculatorModel : PageModel
    {

        [BindProperty]
        [Required]
        [Range(0.0, double.MaxValue, ErrorMessage = "Must be greater than zero.")]
        public double interest_rate { get; set; }

        [BindProperty]
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Must be greater than zero.")]
        public double deposit_amount { get; set; }

        public void OnPost()
        {
        }
    }
}
