using System.ComponentModel.DataAnnotations.Schema;

namespace Conway.WeighCON.Domain.Entities.Customers
{
    public class Customer
    {
        public decimal Id { get; set; }

        public string? CustomerName { get; set; }

        public string Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? Address3 { get; set; }

        public string Town { get; set; }

        public string County { get; set; }

        public string Postcode { get; set; }

        public string? Phone { get; set; }

        public string? ExpiredString { get; set; }

        [NotMapped]
        public bool Expired => ExpiredString == "Y";
        
        public string? SuppressInvoicePrintString { get; set; }
        
        public decimal? DWSurchargeValue { get; set; }
        
        public string? DWSurchargeIndicatorString { get; set; }
        
        public decimal? InsuredValue { get; set; }
        
        public decimal? CustomerRating { get; set; }
        
        public DateTime? LastUpdated { get; set; }
        
        public string? SuppressMinmixString { get; set; }
        
        public DateTime DateCreated { get; set; }
        
        
        public string? RepresentativeCode { get; set; }
        
        public decimal SalesLedgerAccount { get; set; }
        
        public string ShortName { get; set; }
        
        public string? ContactName { get; set; }
        
        public string? CreditRating { get; set; }
        
        public string? CustomerType { get; set; }
        
        public string? InterCompanyAccountString { get; set; }
        
        public string? SurchargeIndicatorString { get; set; }
        
        public decimal? SurchargeValue { get; set; }
        
        public string? SuppressDueDateString { get; set; }
        
        public string? PoRequiredString { get; set; }
        
        public string? CashSaleAccountString { get; set; }
        
        public string CustomerCategory { get; set; }
        
        public DateTime? DateLastReviewed { get; set; }
        
        public decimal? ReviewInterval { get; set; }
        
        public string? TradexString { get; set; }
        
        public string? SingleTicketInvoicesString { get; set; }
        
        public decimal? BusinessUnit { get; set; }
    }
}
