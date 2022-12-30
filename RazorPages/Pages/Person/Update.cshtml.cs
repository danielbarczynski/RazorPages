using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Person
{
    public class UpdateModel : PageModel
    {
        private readonly PersonContext _context;
        public UpdateModel(PersonContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PersonModel Person { get; set; }

        public void OnGet(int id)
        {
            Person = _context.Persons.Find(id);
        }

        public IActionResult OnPost()
        {
            _context.Persons.Update(Person);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
