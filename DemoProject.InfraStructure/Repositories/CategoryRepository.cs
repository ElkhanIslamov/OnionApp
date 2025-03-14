using DemoProject.Application.Repostories;
using DemoProject.Domain.Entities;
using DemoProject.Infrastructure.EFCore;

namespace DemoProject.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddCategory(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }

    public List<Category> GetCategories()
    {
        var categories = _context.Categories.ToList();
        return categories;
    }

    public void RemoveCategory(int id)
    {
        var existCategory = _context.Categories.Find(id);

        if (existCategory == null)
        {
            Console.WriteLine("Not found");
            return;
        }

        _context.Categories.Remove(existCategory);
        _context.SaveChanges();
    }

    public void UpdateCategory(int id, Category category)
    {
        var existCategory = _context.Categories.Find(id);

        if (existCategory == null)
        {
            Console.WriteLine("Not found");
            return;
        }


        existCategory.Name = category.Name;
        _context.SaveChanges();
    }
}
