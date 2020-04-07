﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	class QuickSortStrategy : SortedStrategy
	{
		public override void Sort(List<int> dataset)
		{
			Console.WriteLine("Implement Quick Sort Strategy ...");
		}
	}
}
