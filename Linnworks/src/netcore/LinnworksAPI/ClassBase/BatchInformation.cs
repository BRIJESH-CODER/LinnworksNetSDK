using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchInformation
	{
        /// <summary>
        /// Stock item id 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Stock item batch data 
        /// </summary>
		public List<StockItemBatch> ItemBatchInformation;
	} 
}