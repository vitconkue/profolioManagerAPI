using System;

namespace ApplicationCore.Entity.Asset
{
    public class PersonalAsset : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime InputDay { get; set; } = DateTime.Now;
        public decimal InputMoneyAmount { get; set; }
        public string InputCurrency { get; set; } = "VND"; 
        public DateTime LastChanged { get; set; } = DateTime.Now;
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
        public string Description { get; set; }
    }
}