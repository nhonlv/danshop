using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DanShop.Model.Models
{
    [Table("VisitorStatistics")]
    internal class VisitorStatistic
    {
        [Key]
        public Guid ID { set; get; }

        public DateTime VisitedDate { set; get; }

        [MaxLength(50)]
        public string IPAdress { set; get; }
    }
}