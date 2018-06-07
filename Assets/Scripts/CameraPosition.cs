using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

	private static float camera_y = 2.92f;
	private static float camera_x = 0.0f;
	private static float camera_z = 0.0f;

	public GameObject cameraController;

	// Use this for initialization
	void Start () {		
		if (camera_x == 0.0f) {
			camera_x = cameraController.transform.position.x;
		}
		if (camera_z == 0.0f) {
			camera_z = cameraController.transform.position.z;
		}
		cameraController.transform.position = new Vector3 (camera_x, camera_y, camera_z);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up")) {
			print ("up");
			camera_y = camera_y + 0.05f;
			cameraController.transform.position = new Vector3 (camera_x, camera_y, camera_z);
		}
		if (Input.GetKeyDown ("down")) {
			print ("down");
			camera_y = camera_y - 0.05f;
			cameraController.transform.position = new Vector3 (camera_x, camera_y, camera_z);
		}
	}
}
