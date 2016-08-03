using UnityEngine;
using System.Collections;

public class Duck : AbstractBehavior {

	public float scale = .5f;
	public bool ducking;
	public float centerOffsetY = 0f;

	private CircleCollider2D circleCollider;
	private Vector2 originalCenter;

	protected override void Awake () {
		base.Awake ();

		circleCollider = GetComponent<CircleCollider2D> ();
		originalCenter = circleCollider.offset;
	}

	protected vitual void OnDuck(bool value){

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
