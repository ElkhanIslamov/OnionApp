using DemoProject.Domain.Entities;

namespace DemoProject.Application.Services.Contracts;

public interface ICategoryService
{
    List<Category> GetCategories();
    void AddCategory(Category category);
    void RemoveCategory(int id);
    void UpdateCategory(int id, Category category);
}
