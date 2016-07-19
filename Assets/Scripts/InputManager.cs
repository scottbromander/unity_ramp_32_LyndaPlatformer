using UnityEngine;
using System.Collections;

public enum Buttons{
	Right,
	Left,
}

public enum Condition{
	GreaterThan,
	LessThan
}

[System.Serializable]
public class InputAxisState {
	public string axisName; //example 'Horizontal'
	public float offValue; //Is value on or off?
	public Buttons button; //Our enum from above
	public Condition condition;

	public bool value{
		get{
			var value = Input.GetAxis (axisName);

			switch (condition) {
			case Condition.GreaterThan:
				return value > offValue;
			case Condition.LessThan:
				return value < offValue;
			}

			return false;
		}
	}
}

public class InputManager : MonoBehaviour {

	public InputAxisState[] inputs;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (var input in inputs) {
			if (input.value) {
				Debug.Log ("Input detected: " + input.button);
			}
		}
	}
}
