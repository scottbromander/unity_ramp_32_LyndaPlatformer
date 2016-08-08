using UnityEngine;
using System.Collections;

public class FireProjectile : AbstractBehavior {

	public float shootDelay = 0.5f;
	public GameObject projectilePrefab;

	private float timeElapsed = 0;

	void Update(){
		if (projectilePrefab != null) {
			var canFire = inputState.GetButtonValue (inputButtons [0]);

			if (canFire && timeElapsed > shootDelay) {
				CreateProjectile (transform.position);
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}

	public void CreateProjectile(Vector2 pos){
		var clone = Instantiate (projectilePrefab, pos, Quaternion.identity) as GameObject;
		clone.transform.localScale = transform.localScale;

	}
}
