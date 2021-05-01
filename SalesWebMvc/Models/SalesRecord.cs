using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Date cannot be empty")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Amount cannot be empty")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }

        [Required]
        public SalesStatus Status{ get; set; }

        public Seller Seller { get; set; }

        [Required]
        [Display(Name = "Seller")]
        public int SellerId { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

    }
}
