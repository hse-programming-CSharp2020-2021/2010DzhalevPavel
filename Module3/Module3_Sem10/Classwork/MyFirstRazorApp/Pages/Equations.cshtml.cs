using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstRazorApp.Pages
{
    public class Equations : PageModel
    {
        public string Message { get; set; }
        
        public void OnGet()
        {
            Message = "Enter data ";
        }

        public void OnPost(int a, int b, int c)
        {
            double d = b * b - 4 * a * c;
            double x1, x2;
            if (d < 0) Message = "No roots.";
            if (d == 0)
            {
                x1 = -b / 2 * a;
                Message = $"{x1} is a double root";
            }
            else
            {
                x1 = -b + Math.Sqrt(d)/ 2 * a;
                x2 = -b - Math.Sqrt(d)/ 2 * a;
                Message = $"Roots are {x1} and {x2}";
            }
        }
    }
}