using UnityEngine;
using System.Collections;

public class ENNEMYspawner : MonoBehaviour {
	public GameObject ennemyInstance;
	public Vector2 frequenceSpawnSec= new Vector2(1f, 2f);
	public float reductionTempsSpawnSeconde = .2f;
	public int nbFoisAReduire= 30;

	public ZoneDefense ZD;

	private float compteurSpawn=0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (ZD.GetGameOver()){
			return;}

		compteurSpawn -= Time.deltaTime;
	//Debug.Log (compteurSpawn);
		if (compteurSpawn <= 0f) {
			GameObject go = Instantiate (ennemyInstance, transform.position, Quaternion.identity) as GameObject;
			compteurSpawn = Random.Range (frequenceSpawnSec.x, frequenceSpawnSec.y);

			if (nbFoisAReduire > 0) {
				frequenceSpawnSec.x -= reductionTempsSpawnSeconde;
				frequenceSpawnSec.y -= reductionTempsSpawnSeconde;
				nbFoisAReduire -= 1;
			}
		}

	}
}
