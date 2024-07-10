using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FinancialApplication.Pages
{
    public class TipCalculatorModel : PageModel
    {
        // Model binding for user input

        [BindProperty]
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total must be a positive number.")]
        public double total { get; set; }

        [BindProperty]
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Tip must be a positive number.")]
        public double tip_percentage { get; set; }

        [BindProperty]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Must be a positive whole number.")]
        public int num_people { get; set; }

        // Properties to store calculated values
        public double tip_amount { get; set; }
        public double total_after_tip { get; set; }
        public double total_per_person { get; set; }

        public void OnPost()
        {
            tip_amount = total * tip_percentage;
            total_after_tip = tip_amount + total;
            total_per_person = total_after_tip / num_people;
        }
    }
}
