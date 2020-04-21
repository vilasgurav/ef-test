using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Layer.Transactions
{
    public class ProfitOrLoss
    {
        /// <summary>
        /// If set to true them the amout is in profit; else loss.
        /// </summary>
        public bool? IsProfit { get; set; }
        /// <summary>
        /// Profit or loss amount.
        /// </summary>
        public decimal? Amount { get; set; }
    }
}
