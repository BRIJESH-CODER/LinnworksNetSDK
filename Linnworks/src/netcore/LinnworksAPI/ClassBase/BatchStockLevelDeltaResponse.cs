using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchStockLevelDeltaResponse
	{
		public List<BatchStockLevelDelta> ProcessedDeltas;

		public Boolean ProcessedContainsErrors;
	} 
}