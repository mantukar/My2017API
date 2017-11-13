using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApi.Model.Entities
{
   public class ProductOption:IEntityBase
    {
       // public int ProductOptionId { get; set; }
        public int ProductId { get; set; }
        public int OptionId { get; set; }
        public double OptionPriceIncrement { get; set; }
        public int OptionGroupId { get; set; }
        public int Id { get; set; }
    }
}
