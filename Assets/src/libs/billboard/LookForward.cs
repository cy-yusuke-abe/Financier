using UnityEngine;
using System.Collections;

public class LookForward : MonoBehaviour {

	public Camera target;

	public float width;
	public float height;
	public Vector2 uv0, uv1, uv2, uv3;

	public bool fixVertical;

	private Mesh mesh;
	private MeshFilter meshFilter;

	void Start () {
		var left = width / 2.0f;

		var vertices = new Vector3[4];
		vertices[0] = new Vector3(-left, 0.0f, 0.0f);
		vertices[1] = new Vector3(left, 0.0f, 0.0f);
		vertices[2] = new Vector3(-left, height, 0.0f);
		vertices[3] = new Vector3(left, height, 0.0f);

		var normals = new Vector3[4];
		normals[0] = -Vector3.forward;
		normals[1] = -Vector3.forward;
		normals[2] = -Vector3.forward;
		normals[3] = -Vector3.forward;

		int[] triangles = new int[6] { 1, 2, 0, 1, 3, 2 };

		var uv = new Vector2[4];

		uv[0] = uv0;
		uv[1] = uv1;
		uv[2] = uv2;
		uv[3] = uv3;

		mesh = new Mesh();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.normals = normals;
		mesh.uv = uv;

		meshFilter = (MeshFilter)GetComponent<MeshFilter>();
		meshFilter.sharedMesh = mesh;
	}
	
	void Update () {
/*		
		Vector3 pos = target.transform.position;

		if(fixVertical) {
			pos.y = meshFilter.transform.position.y;
		}
*/
//		var rotation = meshFilter.transform.rotation;
		var rotation = target.transform.rotation;
//		rotation.y = target.transform.rotation.y;

		meshFilter.transform.rotation = rotation;

		mesh.RecalculateBounds();
		mesh.RecalculateNormals();

		meshFilter.sharedMesh = mesh;
	}
}
