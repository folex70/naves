using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shot : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		speed = 0.4f;
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down*speed);  //(0,++)
	}

	void OnCollisionEnter2D(Collision2D col){

		if(col.gameObject.tag == "Limit" || col.gameObject.tag == "Player"){
			GameObject.Destroy (gameObject,0);
		}
	}

}
