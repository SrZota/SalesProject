using Microsoft.AspNetCore.Mvc.Rendering;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class SalesRecordViewModel
    {
        public SalesRecord SalesRecord { get; set; }

        public ICollection<Seller> Sellers { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select a Items")]
        public SalesStatus SalesStatus { get; set; }

    }
}
