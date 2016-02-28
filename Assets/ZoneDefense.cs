using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZoneDefense : MonoBehaviour {
	public float NbPV= 30f;
	public float DegatsEnemy= 2f;
	public GameObject EcranGameOver;
	public Text TimerSurvie;

	private bool GameOver = false;
	private float tempsSurvie = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameOver) {
			tempsSurvie += Time.deltaTime;
			TimerSurvie.text = tempsSurvie + "";
		}
	}

	void OnTriggerEnter(Collider c){
		if (c.tag == "ENEMY") {
			NbPV -= DegatsEnemy;
			Destroy (c.gameObject);

			if (!GameOver && NbPV <= 0f) {
				EcranGameOver.SetActive (true);
				GameOver = true;
				//Application.Quit ();
			}
		}

	}

	public bool GetGameOver(){
		return GameOver;
	}

}
