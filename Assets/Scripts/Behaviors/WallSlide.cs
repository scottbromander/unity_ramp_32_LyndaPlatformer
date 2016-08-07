﻿using UnityEngine;
using System.Collections;

public class WallSlide : StickToWall {

	public float slideVelocity = -5f;


	// Update is called once per frame
	override protected void Update () {
		base.Update ();

		if (onWallDetected) {
			var velY = slideVelocity;

			body2d.velocity = new Vector2 (body2d.velocity.x, velY);
		}
	}

	override protected void OnStick(){
		body2d.velocity = Vector2.zero;
	}

	override protected void OffWall(){

		//Makes it do nothing
	}
}
