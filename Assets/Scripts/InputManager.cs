using UnityEngine;
using System.Collections;

public enum Buttons{
	Right,
	Left,
}

[System.Serializable]
public class InputAxisState {
	public string axisName; //example 'Horizontal'
	public float offValue; //Is value on or off?
	public Buttons button; //Our enum from above
}

public class InputManager : MonoBehaviour {

	public InputAxisState[] inputs;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
