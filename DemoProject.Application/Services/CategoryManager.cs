using DemoProject.Application.Repostories;
using DemoProject.Application.Services.Contracts;
using DemoProject.Domain.Entities;

namespace DemoProject.Application.Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryManager(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public void AddCategory(Category category)
        {
        _repository.AddCategory(category);

        }

        public List<Category> GetCategories()
        {
            return _repository.GetCategories();

        }

        public void RemoveCategory(int id)
        {
            _repository.RemoveCategory(id);
        }

        public void UpdateCategory(int id, Category category)
        {
            _repository.UpdateCategory(id, category);
        }
    }
}
