using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FinancialApplication.Pages
{
    public class SavingsCalculatorModel : PageModel
    {

        [BindProperty]
        [Required]
        [Range(0.0, double.MaxValue, ErrorMessage = "Please enter a number greater than 0")]
        public double starting_balance { get; set; }

        [BindProperty]
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a number greater than 0")]
        public double contribution_amount { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please select a compounding frequency")]
        public int contribution_frequency { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter a number greater than 0")]
        public int years {  get; set; }

        [BindProperty]
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a number greater than 0")]
        public double annual_interest { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please select a compound frequency")]
        public int compound_frequency { get; set; }




        public void OnPost()
        {
            //Calculations



        }
    }
}
