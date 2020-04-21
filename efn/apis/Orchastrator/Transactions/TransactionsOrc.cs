
using Domain.Layer;
using Domain.Layer.Transactions;
using Repository;
using Repository.Transactions;
using System;
using product = Domain.Layer.Product;
namespace Orchastrator.Transactions
{
    public class TransactionsOrc : ITransactionsOrc
    {
        IProductRepository productRep;
        IBuyingTransactionRepository buyingTransactionRep;
        ISellingTransaction sellingTransaction;
        /// <summary>
        /// The method to create selling transaction.
        /// </summary>
        /// <param name="sellingTransaction">Selling Transaction domain object.</param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        public bool CreateSellingTransaction(SellingTransaction sellingTransaction)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method to create 
        /// </summary>
        /// <param name="buyingTransaction"></param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        public bool CreateBuyingTransaction(Domain.Layer.Transactions.BuyingTransaction buyingTransaction)
        {
            buyingTransactionRep = new BuyingTransactionRepository();
            return buyingTransactionRep.CreateBuyingTransaction(buyingTransaction);
        }

        /// <summary>
        /// The method to get last buying transaction.
        /// </summary>
        /// <returns>The buying transaction domain object.</returns>
        public Domain.Layer.Transactions.BuyingTransaction GetLastBuyingTransaction(short userId)
        {
            return buyingTransactionRep.GetLastBuyingTransaction(userId);
        }

        /// <summary>
        /// The method to calculate profit or loss.
        /// </summary>
        /// <param name="userId">The User id.</param>
        /// <returns>The profi or loss object.</returns>
        public ProfitOrLoss GetProfitOrLoss(short userId)
        {
            try
            {
                buyingTransactionRep = new BuyingTransactionRepository();
                Domain.Layer.Transactions.BuyingTransaction buyingTransaction = buyingTransactionRep.GetLastBuyingTransaction(userId);
                if (buyingTransaction != null)
                {
                    productRep = new ProductRepository();
                    //Hard coded the product since we have only oone product with ID as 1 now.
                    if (CurrentGoldPricePerGram.Instance.currentGoldPricePerGram == null)
                    {
                        CurrentGoldPricePerGram.Instance.currentGoldPricePerGram = productRep.GetProduct(1).PricePerGram;
                    }
                    sellingTransaction = new SellingTransaction();
                    return sellingTransaction.GetProfitOrLoss(buyingTransaction);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
