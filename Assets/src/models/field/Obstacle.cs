using System;

namespace Models.Field {


	/**
	 * @class Field obstacles
	 * */
	public class Obstacle {
		public enum Type {
			CUBE,
		};

		Type type;
		Life life;

		public Obstacle(Obstacle.Type type, Life life) {
			this.life = life;
			this.type = type;
		}
	}
}

