﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayCloud.WebApp.Areas.Admin.Models.PayCloudUserViewModels
{
    public class UserModalViewModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "User name")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "User name must be at least 3 chars!")]
        public string UserName { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Nickname can not be less than 3 and more than 35 symbols!")]
        [Display(Name = "Nickname")]
        public string NickName { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity, ErrorMessage = "Balance can not be less than zero!")]
        public decimal Balance { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required]
        [Display(Name = "Account number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Acount number must be 10 chars!")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "Client name")]
        public string ClientName { get; set; }
    }
}
