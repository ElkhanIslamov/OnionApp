using DemoProject.Application.DTOs;
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

    public void AddProduct(ProductCreateDto createDto)
    {
        var product = new Product
        {
            Name = createDto.Name,
            CategoryId = createDto.CategoryId,
        };
        _repository.AddProduct(product);
    }

    public List<ProductDto> GetProducts()
    {
        var productDtos= new List<ProductDto>();

        foreach (var item in _repository.GetProducts())
        {
            productDtos.Add(new ProductDto
            {
                Id = item.Id,
                Name = item.Name,
                CategoryName = item.Category?.Name,
            });
        }
        return  productDtos;
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
