using DemoProject.Domain.Entities;

namespace DemoProject.Application.Repostories;

public interface ICategoryRepository
{
    List<Category> GetCategories();
    void AddCategory(Category category);
    void RemoveCategory(int id);
    void UpdateCategory(int id, Category category);
}
