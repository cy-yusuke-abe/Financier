using System;

namespace Models {
	
	public class Level : ValueObject {

		readonly int value;

		public Level(int value) {
			this.value = value;
		}

//		abstract Experience requiredExperience();

	}
}

