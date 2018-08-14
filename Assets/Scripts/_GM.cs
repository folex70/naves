using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour {

	public GameObject Enemy;

	public GameObject enemyStartPos;


	// Use this for initialization
	void Start () {
		Instantiate (Enemy, new Vector2 (enemyStartPos.transform.position.x, enemyStartPos.transform.position.y), Quaternion.identity);
		Instantiate (Enemy, new Vector2 (enemyStartPos.transform.position.x+2.0f, enemyStartPos.transform.position.y), Quaternion.identity);
		Instantiate (Enemy, new Vector2 (enemyStartPos.transform.position.x-2.0f, enemyStartPos.transform.position.y), Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
