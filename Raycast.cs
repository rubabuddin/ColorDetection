using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay(ray.origin, ray.direction * 10, Color.cyan);

		RaycastHit hit;

		//string cube_color = hit.transform.gameObject.renderer.material.GetColor("_Color");



		if (Physics.Raycast (ray, out hit) == true) 
		{
			if(hit.transform.gameObject.renderer.material.color == Color.red)
				print("The color of this cube is red");// + hit.transform.gameObject.renderer.material.GetColor("_Color"));	
			else if(hit.transform.gameObject.renderer.material.color == Color.blue)
				print("The color of this cube is blue");
			Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.red);
			//Debug.Log ("Ray hit a " + hit.transform.gameObject.tag);
		}
	}
}
