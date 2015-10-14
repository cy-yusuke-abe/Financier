using System;

namespace Models {
	public class Tribe : Entity {

		readonly public string name;

		public Tribe(UInt32 id, string name) : base(id) {
			this.name = name;
		}
	}
}

