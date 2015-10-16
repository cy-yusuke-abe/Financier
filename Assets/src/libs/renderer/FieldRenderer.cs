using UnityEngine;
using System.Collections;

namespace Libs.Renderer {


	public class FieldRenderer {

		GameObject[] prefabs;

		GameObject[,] fieldObjects;


		public FieldRenderer(Models.Field.Field field) {
 /*
			prefabs = new GameObject[2];
			prefabs[0] = (GameObject)Resources.Load("models/field/FieldGrabel");
			prefabs[1] = (GameObject)Resources.Load("models/field/FieldGlass");

			fieldObjects = new GameObject[field.height, field.width];

			var left = (float)-field.width;
			var top = (float)-field.height;

			for(int y = 0; y < field.height; ++y) {
				for(int x = 0; x < field.width; ++x) {

					var panel = field.panelAt(x, y);

					var pos = new Vector3((float)x * 2.0f + left , 0.0f, (float)y * 2.0f + top);

					fieldObjects[y, x] = (GameObject)Object.Instantiate(prefabs[(int)panel.type], pos, Quaternion.identity);
				}
			}
			*/
		}

	}
}