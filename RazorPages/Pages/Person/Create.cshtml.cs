using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Person
{
    public class CreateModel : PageModel
    {
        private readonly PersonContext _context;
        public CreateModel(PersonContext context)
        {
            _context = context;
        }
        public PersonModel Person { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost(PersonModel person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
