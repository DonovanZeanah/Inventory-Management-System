﻿using IMS.CoreBusiness.Models;
using IMS.UseCases.AdminPortal.Inventories.Interfaces;
using IMS.UseCases.AdminPortal.Inventories.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.AdminPortal.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }
        public async Task ExecuteAsync(Inventory inventory)
        {
            await _inventoryRepository.AddInventoryAsync(inventory);
        }
    }
}