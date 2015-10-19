using System;

namespace Models.Character {

	public class Character : Entity {
		readonly public string name;

		readonly public Tribe tribe;
		
		public Character(UInt32 id, string name, Tribe tribe) : base(id) {
			this.name = name;
			this.tribe = tribe;
		}
	}
}
