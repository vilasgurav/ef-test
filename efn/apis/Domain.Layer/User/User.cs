using Domain.Layer.Common;
using System;

namespace Domain.Layer.User
{
    public class User : BaseClass
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public decimal UsersTotalProductQuantity { get; set; }
    }
}
