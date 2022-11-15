using BookStore.Data;
using BookStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void OnGet()
        {
            Categories = db.Categories;
        }
    }
}
