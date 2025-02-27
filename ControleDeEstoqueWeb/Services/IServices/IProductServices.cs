﻿using ControleDeEstoqueWeb.Models;

namespace ControleDeEstoqueWeb.Services.IServices
{
	public interface IProductServices
	{
		Task<IEnumerable<ProductModel>> FindAllProducts();
		Task<ProductModel> FindProductById(long id);
		Task<ProductModel> CreateProduct(ProductModel model);
		Task<ProductModel> UpdateProduct(ProductModel model);
		Task<bool> DeleteProductById(long id);
	}
}
