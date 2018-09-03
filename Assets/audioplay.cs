using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplay : MonoBehaviour {

	// Use this for initialization
	public void playAudio(){
		this.GetComponent<AudioSource>().Play();
	}
}
