using UnityEngine;
using System.Collections;

public class ENEMYia : MonoBehaviour {
	public float movespeed = 1f;

	GameObject destination;
	// Use this for initialization
	void Start () {
		destination = GameObject.Find ("Destination");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.LookAt (destination.transform.position);
		transform.position += (transform.forward * movespeed);
	}
}
