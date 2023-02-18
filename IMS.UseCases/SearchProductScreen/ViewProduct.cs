﻿using IMS.CoreBusiness.Models;
using IMS.CoreBusiness.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.SearchProductScreen
{
  public class ViewProduct
  {
    private readonly IProductRepository productRepository;

    public ViewProduct(IProductRepository productRepository)
    {
      this.productRepository = productRepository;
    }
    public Product Execute(int id)
    {
      return productRepository.GetProduct(id);
    }
  }
}
