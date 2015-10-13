using System;

namespace Models.Field {

	/**
	 * field panels
	 * */
	public class Panel {
		public enum Type {
			NORMAL,
			BREAKABLE,
			PIT,
			IMMUTABLE_PIT,
			FIRE_PANEL,
			ICE_PANEL,
			GLASS_PANEL,
			POISON_PANEL,
			HOLY_PANEL
		}

		Type type;
		int recoverTime;
		bool enemySide;

		public Panel(Type type, bool enemySide) {
			this.type = type;
			this.enemySide = enemySide;
		}
	
	}
}

