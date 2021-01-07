using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
	public class Square : Shape
	{
		public int Sides { get; set; }

		public override int Area()
		{

			return Sides * Sides;
		}

	}
}
