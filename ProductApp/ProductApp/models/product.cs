using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace juice.Models
{
    public class Product
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public float product_price { get; set; }
        public string product_image { get; set; }
        [DataType(DataType.Date)] 
        public DateTime time_expired { get; set; }

        public int Quantity { get; set; }
    }
}