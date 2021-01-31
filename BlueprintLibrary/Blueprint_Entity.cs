using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlueprintLibrary
{
	public class Blueprint_Entity
	{
		public int entity_number;
		public Point position;

		public Blueprint_Entity(int entity_number, Point position)
		{
			this.entity_number = entity_number;
			this.position = position;
		}
	}
}
