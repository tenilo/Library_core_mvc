using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.ASP.NET.Core.MVC.Models
{
    public class Book
    {
        [Key]
        public int BooKId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageurUrl { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
       
        public Category Category { get; set; }
        


    }
}
