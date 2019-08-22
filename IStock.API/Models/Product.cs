using System;

namespace IStock.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public string ProductName { get; set; }
        public DateTime OpenDate { get; set; }
        public int UserId { get; set; } 
        public double ProCost { get; set; }
        public double ProSell { get; set; }
        public int SupId { get; set; }
        public int GlobalId { get; set; }
        public int MinInStock { get; set; }
        public int TotalInStock { get; set; }
        public bool IsActive { get; set; }        

    }
}