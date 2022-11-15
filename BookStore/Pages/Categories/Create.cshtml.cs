using BookStore.Data;
using BookStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public CreateModel(ApplicationDbContext db)
        {
            this.db = db;
        }
        [BindProperty]
        public Category Category { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.Category.Name == this.Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "The Display order cannot be the same");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await db.Categories.AddAsync(Category);
            await db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
