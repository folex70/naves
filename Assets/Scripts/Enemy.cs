using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Animator animEnemy;
	public int life =3;
	public int rand;
	public GameObject enemyShotPrefab;
	//public GameObject enemyAim;



	// Use this for initialization
	void Start () {
		animEnemy = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		rand = Random.Range (0, 99);
		if (rand == 1) {
			Shot();
		}

	}

	public void Shot(){
		Instantiate (enemyShotPrefab, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			
	}

	void OnCollisionEnter2D(Collision2D col){

		if(col.gameObject.tag == "Limit" || col.gameObject.tag == "Shot"){
			if (life > 0) {
				life--;
			} else {
				animEnemy.Play ("enemy_explode");
				GameObject.Destroy (gameObject,0.5f);
			}

		}

	}
}
