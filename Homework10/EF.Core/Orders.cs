using System;
using System.Collections.Generic;

namespace EF.Core
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public string Id { get; set; }
        public string Customer { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
