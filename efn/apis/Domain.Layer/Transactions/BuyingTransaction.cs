using System;

namespace Domain.Layer.Transactions
{
    public class BuyingTransaction : IBuyingTransaction
    {
        public long PurchasedTransactionId { get; set; }
        public int UserId { get; set; }
        public decimal PurchasedRatePerGram { get; set; }
        public DateTime? PurchasedDate { get; set; }
        public decimal PurchasedQuantity { get; set; }
        public decimal PurchasedPrice { get; set; }
        public decimal PurchasedTax { get; set; }
        public decimal PurchasedTotalPrice { get; set; }
        public short ProductId { get; set; }
    }
}
