using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwBalls : MonoBehaviour {
	public GameObject ballPrefab;
	public GameObject parentObject;
	public Camera arcamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			GameObject temp = Instantiate(ballPrefab);
			temp.transform.parent = parentObject.transform;
			temp.transform.position = arcamera.transform.position;
			temp.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,1)*100f);
		}
	}
}
