﻿using System;
namespace Week2.Esercitazione.Entities
{
	internal class Task
	{
		public string Description { get; set; }
		public DateTime ExpiryDate { get; set; }
		public string Priority { get; set; }

		public override string ToString()
		{
			return $"{Description}-{Priority}-{ExpiryDate} ";
		}

	}
}

	