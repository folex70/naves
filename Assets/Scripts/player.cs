using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float speed;
	public GameObject shot;
	public GameObject aim;
	public float overHeat; //temperatura da arma, se chegar a 100 a arma trava e o jogador precisa esperar esfriar


	// Use this for initialization
	void Start () {
		speed = 0.1f;


	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			//print ("apertei w, a nave sobe");
			transform.Translate (Vector2.up*speed);
		}
		if(Input.GetKey(KeyCode.S)){
			//print ("apertei w, a nave sobe");
			transform.Translate (Vector2.down*speed);
		}
		if(Input.GetKey(KeyCode.D)){
			//print ("apertei w, a nave sobe");
			transform.Translate (Vector2.right*speed);
		}
		if(Input.GetKey(KeyCode.A)){
			//print ("apertei w, a nave sobe");
			transform.Translate (Vector2.left*speed);
		}
		//if(Input.GetKey(KeyCode.Space)){
		if(Input.GetButtonDown("Fire1")){
			
			Instantiate (shot, new Vector2 (aim.transform.position.x, aim.transform.position.y), Quaternion.identity);

		}
	}
}
