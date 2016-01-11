using UnityEngine;
using System.Collections;

public class ScriptA : MonoBehaviour {
	public GameObject GO;

	// Use this for initialization
	void Start () {
		GameObject[] arrayGO = GameObject.FindGameObjectsWithTag ("myTag");
		Transform t;

		foreach (GameObject go in arrayGO) {
			t = go.GetComponent<Transform>();
			t.position = new Vector3(0,0,0);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
