using System;

namespace Models {
	
	public class Experience : ValueObject {

		int value;

		public Experience(int value) : base() {
			this.value = value;
		}

		public static Experience operator +(Experience a, Experience b) {
			return new Experience(a.value + b.value);
		}

		/**
		 * level from experience
		 */
		public Level toLevel() {
			return new Level(1);				
		}
	}
}

