using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using System.Threading.Tasks;
using System.Linq;

namespace StudentManagementSystem.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Check for duplicate student
            bool studentExists = _context.Students.Any(s => s.Name == Student.Name);
            if (studentExists)
            {
                ModelState.AddModelError("Student.Name", "A student with this name already exists.");
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
