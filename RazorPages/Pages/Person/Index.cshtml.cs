using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorPages.Pages.Person
{
    public class IndexModel : PageModel
    {
        private readonly PersonContext _context;
        [BindProperty]
        public PersonModel Person { get; set; }
        [BindProperty]
        public IEnumerable<PersonModel> Persons { get; set; }
        public IndexModel(PersonContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Persons = _context.Persons;
        }

        public IActionResult OnPost(int? id)
        {
            var person = _context.Persons.FirstOrDefault(x => x.Id == id);
            if (person == null)
                return NotFound();

            _context.Remove(person);
            _context.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}
