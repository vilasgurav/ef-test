using Domain.Layer.Transactions;

namespace Repository.Transactions
{

    /// <summary>
    /// The repository class to process selling transactions
    /// </summary>
    public class SellingTransactionRepository : ISellingTransactionRepository
    {
        /// <summary>
        /// The method to create selling transaction.
        /// </summary>
        /// <param name="sellingTransaction">Selling Transaction domain object.</param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        public bool CreateSellingTransaction(SellingTransaction sellingTransaction)
        {
            return true;
        }
    }
}
