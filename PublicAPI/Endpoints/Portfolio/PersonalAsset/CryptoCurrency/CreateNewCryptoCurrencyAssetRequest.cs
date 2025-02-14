using System;
using Microsoft.AspNetCore.Mvc;

namespace PublicAPI.Endpoints.Portfolio.PersonalAsset.CryptoCurrency
{
    public class CreateNewCryptoCurrencyCommand : BaseCreateRequest
    {
        public string Name { get; set; }
        public DateTime InputDay { get; set; }
        public decimal CurrentAmountHolding { get; set; }
        public string Description { get; set; }
        public decimal PurchasePrice { get; set; }
        public string CurrencyCode { get; set; }
        public string CryptoCoinCode { get; set; }
        public decimal? Fee { get; set; }
        public decimal? Tax { get; set; }
    }

    public class CreateNewCryptoCurrencyAssetRequest
    {
        [FromRoute] public int PortfolioId { get; set; }
        [FromBody] public CreateNewCryptoCurrencyCommand CreateNewCryptoCurrencyCommand { get; set; }
    }
}