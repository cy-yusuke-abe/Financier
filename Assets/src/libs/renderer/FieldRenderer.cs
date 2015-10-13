using UnityEngine;
using System.Collections;

namespace Libs.Renderer {


	public class FieldRenderer {

		GameObject[] prefabs;

		GameObject[,] fieldObjects;


		public FieldRenderer(Models.Field.Field field) {
		
			prefabs = new GameObject[1];
			prefabs[0] = (GameObject)Resources.Load("models/field/FieldNormal");

			fieldObjects = new GameObject[field.height, field.width];

			var left = (float)(field.width / -2);
			var top = (float)(field.height / -2);

			for(int y = 0; y < field.height; ++y) {
				for(int x = 0; x < field.width; ++x) {

					var panel = field.panelAt(x, y);

					var pos = new Vector3((float)x + left , 0.0f, (float)y + top);

					fieldObjects[y, x] = (GameObject)Object.Instantiate(prefabs[0], pos, Quaternion.identity);
				}
			}
		}

	}
}