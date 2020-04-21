using Domain.Layer.Constants;
using Domain.Layer.Transactions;
using System.Linq;


namespace Repository.Transactions
{

    /// <summary>
    /// The repository to process buying transactions.
    /// </summary>
    public class BuyingTransactionRepository : IBuyingTransactionRepository
    {
        efn_testEntities3 dbContext = new efn_testEntities3();
        /// <summary>
        /// The method to create 
        /// </summary>
        /// <param name="buyingTransaction"></param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        public bool CreateBuyingTransaction(Domain.Layer.Transactions.BuyingTransaction buyingTransaction)
        {
            dbContext.BuyingTransactions.Add(MapTransaction(buyingTransaction));
            var result = dbContext.SaveChanges();
            return result > 0 ? true : false;
        }

        private BuyingTransaction MapTransaction(Domain.Layer.Transactions.BuyingTransaction buyingTransaction)
        {
            return new BuyingTransaction()
            {
                ProductId = buyingTransaction.ProductId,
                PurchasedDate = buyingTransaction.PurchasedDate,
                PurchasedPrice = buyingTransaction.PurchasedPrice,
                PurchasedQuantity = buyingTransaction.PurchasedQuantity,
                PurchasedRatePerGram = buyingTransaction.PurchasedRatePerGram,
                PurchasedTax = buyingTransaction.PurchasedTax,
                PurchasedTotalPrice = buyingTransaction.PurchasedTotalPrice,
                UserId = buyingTransaction.UserId,


            };
        }

        /// <summary>
        /// The method to get last buying transaction.
        /// </summary>
        /// <returns>The buying transaction domain object.</returns>
        Domain.Layer.Transactions.BuyingTransaction IBuyingTransactionRepository.GetLastBuyingTransaction(short userId)
        {
            var data = dbContext.BuyingTransactions
                               .Where(s => s.UserId == userId)
                               .OrderByDescending(ord => ord.PurchasedDate)
                               .FirstOrDefault();

            return MapData(data);
        }

        private Domain.Layer.Transactions.BuyingTransaction MapData(BuyingTransaction data)
        {
            return new Domain.Layer.Transactions.BuyingTransaction()
            {
                ProductId = (short)data.ProductId,
                PurchasedDate = data.PurchasedDate,
                PurchasedPrice = (decimal)data.PurchasedPrice,
                PurchasedQuantity = (decimal)data.PurchasedQuantity,
                PurchasedRatePerGram = (decimal)data.PurchasedRatePerGram,
                PurchasedTax = (decimal)(data.PurchasedPrice * DomainConstants.GST_PERCENTAGE / 100),
                PurchasedTotalPrice = (decimal)(data.PurchasedPrice + (data.PurchasedPrice * DomainConstants.GST_PERCENTAGE / 100)),
                PurchasedTransactionId = (long)data.PurchasedTransactionId,
                UserId = (int)data.UserId,
            };
        }
    }
}
