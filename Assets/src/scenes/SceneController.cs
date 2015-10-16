using UnityEngine;
using System.Collections.Generic;

using Models;
using Models.Field;

namespace Controllers {

	public class SceneController : MonoBehaviour {

		Libs.Renderer.FieldRenderer fieldCreator;

		float y = -30.0f;


		// Use this for initialization
		void Start () {

			var panels = new List<Panel>();
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GLASS, Panel.Attribute.IMMORTAL, false));

			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GLASS, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GLASS, Panel.Attribute.IMMORTAL, false));

			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GRABEL, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GLASS, Panel.Attribute.IMMORTAL, false));
			panels.Add(new Panel(Panel.Type.GLASS, Panel.Attribute.IMMORTAL, false));


			var field = new Field(new Point2D(6, 3), panels);

			fieldCreator = new Libs.Renderer.FieldRenderer(field);

			var pref = (GameObject)Resources.Load("models/character/Character1");

			var camera = (Camera)FindObjectOfType<Camera>();

			var obj = (GameObject)Instantiate(pref, new Vector3(-2.0f, 0.0f, -1.0f), Quaternion.identity);
			obj.GetComponentInChildren<LookForward>().target = camera;

			var obj1 = (GameObject)Instantiate(pref, new Vector3(-6.0f, 0.0f, -1.0f), Quaternion.identity);
			obj1.GetComponentInChildren<LookForward>().target = camera;

			var obj2 = (GameObject)Instantiate(pref, new Vector3(-4.0f, 0.0f, -3.0f), Quaternion.identity);
			obj2.GetComponentInChildren<LookForward>().target = camera;

			var obj3 = (GameObject)Instantiate(pref, new Vector3(-4.0f, 0.0f,  1.5f), Quaternion.identity);
			obj3.GetComponentInChildren<LookForward>().target = camera;
		}
		
		// Update is called once per frame
		void Update () {
			var camera = (Camera)FindObjectOfType<Camera>();


			camera.transform.rotation = Quaternion.Euler(30, y, 0);

			y += 0.05f;

		
		}
	}
}
