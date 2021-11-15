using RestWithAspNet.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithAspNet.Model
{
    [Table("books")]
    public class Book :  BaseEntity
    {
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("launch_Date")]
        public DateTime LaunchDate { get; set; }
    }
}
