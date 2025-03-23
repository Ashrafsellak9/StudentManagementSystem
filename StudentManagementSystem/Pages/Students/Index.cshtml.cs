using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace StudentManagementSystem.Pages.Students
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; } = new List<Student>();

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string CourseFilter { get; set; } = string.Empty;

        public async Task OnGetAsync()
        {
            IQueryable<Student> query = _context.Students;

            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                query = query.Where(s => EF.Functions.Like(s.Name, $"%{SearchTerm}%"));
            }

            if (!string.IsNullOrWhiteSpace(CourseFilter))
            {
                query = query.Where(s => s.Course == CourseFilter);
            }

            Students = await query.ToListAsync();
        }
    }
}
