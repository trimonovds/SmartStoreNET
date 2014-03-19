﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartStore.Core.Domain.Catalog
{
    
    /// <summary>
    /// Interface for shared product variant data between
    /// variants and variant combinations
    /// </summary>
    public interface IProductVariant
    {
        int Id { get; }
        string Sku { get; set; }
        string Gtin { get; set; }
        string ManufacturerPartNumber { get; set; }
        int StockQuantity { get; set; }
        int? DeliveryTimeId { get; set; }
        decimal Length { get; set; }
        decimal Width { get; set; }
        decimal Height { get; set; }
        BasePriceQuotation BasePrice { get; set; }
		int ManageInventoryMethodId { get; }

        ICollection<ProductVariantAttributeCombination> ProductVariantAttributeCombinations { get; }
    }

}