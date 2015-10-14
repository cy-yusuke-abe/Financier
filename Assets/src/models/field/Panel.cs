using System;

namespace Models.Field {

	/**
	 * field panels
	 * */
	public class Panel {
		public enum Type {
			GRABEL = 0,
			GLASS,
			FIRE,
			ICE,
			POISON,
			HOLY_PANEL,
			PIT
		}

		public enum Attribute {
			IMMORTAL,
			BREAKABLE,
			RECOVERABLE
		}


		readonly public Type type;
		readonly public Attribute attr;
		readonly public int recoverTime;
		readonly public bool enemySide;

		public Panel(Type type, Attribute attr, bool enemySide) {
			this.type = type;
			this.attr = attr;
			this.enemySide = enemySide;
		}


	}
}

