using DemoProject.Application.Repostories;
using DemoProject.Application.Services.Contracts;
using DemoProject.Domain.Entities;

namespace DemoProject.Application.Services;

public class ProductManager : IProductService
{
    private readonly IProductRepository _repository;

    public ProductManager(IProductRepository repository)
    {
        _repository = repository;
    }

    public void AddProduct(Product product)
    {
        _repository.AddProduct(product);
    }

    public List<Product> GetProducts()
    {
        return _repository.GetProducts();
    }

    public void RemoveProduct(int id)
    {
        _repository.RemoveProduct(id);
    }

    public void UpdateProduct(int id, Product product)
    {
        _repository.UpdateProduct(id, product);
    }
}
