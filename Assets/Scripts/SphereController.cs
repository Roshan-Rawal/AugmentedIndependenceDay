using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {
	public GameObject parentObject;
	// Use this for initialization
	void Start () {
		transform.parent = parentObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision hit){
		UnityEngine.Debug.Log(hit.transform.name);
	}
}
