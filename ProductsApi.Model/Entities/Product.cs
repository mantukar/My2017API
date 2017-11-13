using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApi.Model.Entities
{
    public class Product : IEntityBase
    {
        //public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       // public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double ProductWeight { get; set; }
        public string ProductCartDesc { get; set; }
        public string ProductShortDesc { get; set; }
        public string ProductLongDesc { get; set; }
        public string ProductThumb { get; set; }
        public string ProductImage { get; set; }
        public int ProductCategoryID { get; set; }
        public DateTime ProductUpdateDate { get; set; }
        public double ProductStock { get; set; }
        public Int16 ProductLive { get; set; }
        public Int16 ProductUnlimited { get; set; }
        public string ProductLocation { get; set; }
        public string ProductStatus { get; set; }
        public int Id { get ; set ; }
    }
}
