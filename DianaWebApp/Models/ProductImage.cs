﻿namespace DianaWebApp.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImgUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
