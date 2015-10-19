using System;

namespace Models {
	public class Tribe : Entity {

		readonly public string name;

		readonly public Parameter parameter;

		public Tribe(UInt32 id, string name, Parameter parameter) : base(id) {
			this.name = name;
			this.parameter = parameter;
		}
	}
}

