using System;

namespace Models {

	public class Parameter : ValueObject {

		static readonly public Parameter zero = new Parameter(0, 0, 0, 0, 0);

		readonly public UInt32 strength;
		readonly public UInt32 constitution;
		readonly public UInt32 dextarity;
		readonly public UInt32 wisdom;
		readonly public UInt32 intelligence;

		public Parameter(UInt32 strength, UInt32 constitution, UInt32 dextarity, UInt32 wisdom, UInt32 intelligence) : base() {
			this.strength = strength;
			this.constitution = constitution;
			this.dextarity = dextarity;
			this.wisdom = wisdom;
			this.intelligence = intelligence;
		}


		static public Parameter operator +(Parameter a, Parameter b) {

			return new Parameter(
				a.strength + b.strength,
				a.constitution + b.constitution,
				a.dextarity + b.dextarity,
				a.wisdom + b.wisdom,
				a.intelligence + b.intelligence
			);
		}

		static public Parameter operator -(Parameter a, Parameter b) {
			return new Parameter(
				a.strength - b.strength,
				a.constitution - b.constitution,
				a.dextarity - b.dextarity,
				a.wisdom - b.wisdom,
				a.intelligence - b.intelligence
			);
		}



	}
}

