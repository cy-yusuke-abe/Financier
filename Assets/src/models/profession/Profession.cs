using System;
using System.Collections.Generic;

using Libs;

namespace Models.Profession {

	public class Profession : Entity {

		readonly public Option<Profession> archType;

		readonly Parameter parameter;

		readonly int requiredLevel;

		public Profession(UInt32 id, Option<Profession> archType, Parameter parameter, int requiredLevel) : base(id) {
			this.archType = archType;
			this.parameter = parameter;
		}

		public bool isArchType {
			get { return this.archType.nonEmpty; }
		}

		/**
		 * 
		 * list of promoted professions
		 * 
		 */
		public List<Profession> promotedProfessions() {

//			return ProfessionRepository.findAllPromoted(id);

			return new List<Profession>();
				
		}

	}
}

