using System;

namespace Models {
	public class Entity {

		readonly public UInt32 id;

		public Entity(UInt32 id) {
			this.id = id;
		}

		override public bool Equals(System.Object that) {
			if(that == null) {
				return false;
			}

			if(that.GetType() != this.GetType()) {
				return false;				
			}

			return this.id == ((Entity)that).id;
		}

		override public int GetHashCode() {
			return id.GetHashCode();
		}
	}
}

