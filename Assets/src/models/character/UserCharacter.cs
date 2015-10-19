using System;
using System.Collections.Generic;

using Models.Profession;

namespace Models.Character {

	public class UserCharacter {
		Character character;

		List<Profession.Profession> professions;

		Experience exp;

		Parameter currentParameter;

		Parameter bonusPoint;


		public UserCharacter(Character character) {
			this.character = character;
			this.professions = new List<Profession.Profession>();
			this.exp = new Experience(0);

			this.bonusPoint = Parameter.zero;

			this.currentParameter = character.tribe.parameter;
		}

		/**
		 * 職業を設定する
		 */
		public void setProfession(Profession.Profession profession) {
			professions.Add(profession);
		}


		public Parameter parameter {
			get {
				return currentParameter + bonusPoint;
			}
		}

		/**
		 * add bonus point
		 */
		public void addBonusPoint(Parameter parameter) {
			bonusPoint += parameter;
		}

		/**
		 * current profession
		 */
		public Profession.Profession currentProfession {
			get {
				if(professions.Count == 0) {
					return new Profession.Profession(1, Libs.Option.empty<Profession.Profession>(), Parameter.zero, 0);
				}
				return professions[professions.Count - 1];
			}
		}

		/**
		 * add experience
		 */
		public Level addExperience(Experience exp) {

			this.exp += exp;

			return this.exp.toLevel();
		}
	}


}

