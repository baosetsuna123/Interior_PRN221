﻿using CHC.Domain.Enums;

namespace CHC.Domain.Dtos.Contract
{
    public class UpdateContractRequest
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public double FinalOffer { get; set; } = 0;
        public int Discount { get; set; } = 0;
        public Guid CustomerId { get; set; }
        public Guid StaffId { get; set; }
        public Guid QuotationId { get; set; }
        public ContractStatus Status { get; set; } = ContractStatus.Progressing;
    }
}
