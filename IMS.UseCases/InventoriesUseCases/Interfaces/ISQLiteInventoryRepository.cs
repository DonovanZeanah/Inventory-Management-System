﻿using IMS.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.InventoryUseCases.Interfaces
{
    public interface ISQLiteInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name = "");
        Task<bool> ExistsAsync(Inventory inventory);
        Task AddInventoryAsync(Inventory inventory);
        Task UpdateInventoryAsync(Inventory inventory);
        Task<Inventory> GetInventoryByIdAsync(int inventoryId);

    }
}
