﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Theory
{
	class Plane : IVehicle
	{
		public void Run()
		{
			Console.WriteLine("The plane is flying ...");
		}
	}
}
