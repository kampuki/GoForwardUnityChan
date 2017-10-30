using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour {
	
	public AudioClip sound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag == "CubePrefabTag" || other.gameObject.name == "ground") {

			GetComponent<AudioSource> ().PlayOneShot (sound);
		}
	}
}
