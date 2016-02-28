using UnityEngine;
using System.Collections;

public class hit_ennemies : MonoBehaviour {

	public GameObject mouton;

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = mouton.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			animator.SetTrigger ("hit");
		}
		animator.SetBool ("course", Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow));
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "ENEMY" && animator.GetCurrentAnimatorStateInfo(0).IsName("hit")) {
			DestroyObject (col.gameObject);
		}
	}
}
