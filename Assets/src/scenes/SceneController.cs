using UnityEngine;
using System.Collections.Generic;

using Models;
using Models.Field;

namespace Controllers {

	public class SceneController : MonoBehaviour {

		Libs.Renderer.FieldRenderer fieldCreator;

		// Use this for initialization
		void Start () {

			var panels = new List<Panel>();
			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));

			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));

			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));

			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));

			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));

			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));

			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));
			panels.Add(new Panel(Panel.Type.NORMAL, false));

			var field = new Field(new Point2D(6, 3), panels);

			fieldCreator = new Libs.Renderer.FieldRenderer(field);

		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}
