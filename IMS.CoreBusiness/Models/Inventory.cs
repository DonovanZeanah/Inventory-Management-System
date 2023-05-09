﻿using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }

        //[Required]
        public string? InventoryName { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]

        public int Quantity { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Price must be greater than 0")]

        public double? Price { get; set; }
        #region ===[ Source - Entity Relationship ]=============================================================

        public int SourceId { get; set; }
        public Source? Source { get; set; }

        #endregion


    }
}

 



