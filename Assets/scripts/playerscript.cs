using UnityEngine;
using System.Collections;

public class playerscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		if (Input.GetKeyDown("right")) {
			temp.x += 10;
		}
		else if (Input.GetKeyDown("left")) {
			temp.x -= 10;
		}
		else if (Input.GetKeyDown("up")) {
			temp.z += 10;
		}
		else if (Input.GetKeyDown("down")) {
			temp.z -= 10;
		}
		transform.position = temp;
	}
}
