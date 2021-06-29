using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Models
{
    public class InventoryModel    //inventory w/ FK annotations 
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int QuanStore { get; set; }

        public InventoryModel(int StoreId, int ProductId, int QuanStore)
        {
            this.StoreId = StoreId;
            this.ProductId = ProductId;
            this.QuanStore = QuanStore;
        }

        public InventoryModel()
        {
        }
    }
}
