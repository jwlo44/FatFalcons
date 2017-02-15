using UnityEngine;
using System.Collections;

public class BounceOffBouncer : MonoBehaviour {
	Rigidbody2D r;
	public Vector2 bounceForce;
	// Use this for initialization
	void Start () {
		r = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Bouncer") {
			r.velocity = new Vector2(r.velocity.x, 0);
			r.AddForce(bounceForce);
			Debug.Log("Wheee!");
		}
	}
}
