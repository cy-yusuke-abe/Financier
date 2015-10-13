using UnityEngine;
using System.Collections.Generic;

namespace Models.Field {

	public class Field {

		Point2D size;
		List<Panel> panels;

		public Field(Point2D size, List<Panel> panels) {
			this.size = size;
			this.panels = panels;
		}

		public int width {
			get {
				return size.x;
			}
		}

		public int height {
			get {
				return size.y;
			}
		}

		public Panel panelAt(int x, int y) {
			return panels[(y * size.x) + x];
		}
	}
}
