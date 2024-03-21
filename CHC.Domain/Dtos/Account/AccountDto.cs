﻿using CHC.Domain.Entities;
using CHC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CHC.Domain.Common;
using CHC.Domain.Dtos.Contract;
using CHC.Domain.Dtos.Quotation;
using CHC.Domain.Dtos.Feedback;
using CHC.Domain.Dtos.Interior;

namespace CHC.Domain.Dtos.Account
{
    public class AccountDto : BaseEntity
    {
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public RoleType Role { get; set; } = RoleType.Customer;
        public AccountStatus Status { get; set; } = AccountStatus.Active;
        public virtual ICollection<InteriorViewModel> Interiors { get; set; } = new List<InteriorViewModel>();
        public virtual ICollection<ContractViewModel> Contracts { get; set; } = new List<ContractViewModel>();
        public virtual ICollection<FeedbackViewModel> Feedbacks { get; set; } = new List<FeedbackViewModel>();
        public virtual ICollection<QuotationDto> Quotations { get; set; } = new List<QuotationDto>();
    }
}
