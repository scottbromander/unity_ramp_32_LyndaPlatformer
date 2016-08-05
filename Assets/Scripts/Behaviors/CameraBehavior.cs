using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {
	public Camera camera;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		var currentCameraPosition = new Vector3 (camera.transform.position.x, camera.transform.position.y, camera.transform.position.z);
		var currentPlayerPosition = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z);

		var newX = currentCameraPosition.x + (-(currentCameraPosition.x - currentPlayerPosition.x) / 2);
		var newY = currentCameraPosition.y + (-(currentCameraPosition.y - currentPlayerPosition.y) / 2);

		var newCameraPosition = new Vector3 (newX, newY, currentCameraPosition.z);

		camera.transform.position = newCameraPosition;
	}
}
