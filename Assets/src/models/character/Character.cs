using System;

namespace Models.Character {

	public class Character : Entity {
		readonly public string name;
		readonly public Life maxLife;
		readonly public Parameter baseParameter;

		public Character(UInt32 id, string name, Life life, Parameter parameter) : base(id) {
			this.name = name;
			this.maxLife = life;
			this.baseParameter = parameter;
		}
	}
}
