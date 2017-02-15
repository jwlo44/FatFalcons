using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour {

	public float speed;
	public string axis;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   // add a force to the rigidbody baseed on horizontal input
		this.GetComponent<Rigidbody2D> ().AddForce (new Vector2(Input.GetAxis (axis) * speed, 0));
	}
}
