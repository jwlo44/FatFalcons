using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {
	public float minX, minY, maxX, maxY;
	public Vector3 startpos;
    private Transform tr;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        tr = transform;
        rb = GetComponent<Rigidbody2D>();
		this.startpos = tr.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = tr.position;

        float range = maxX - minX;
        while (pos.x > maxX)
            pos.x -= range;
        while (pos.x < minX)
            pos.x += range;

        if (pos.y < minY || pos.y > maxY) {
            pos = startpos;
            rb.velocity = Vector2.zero;
        }

        tr.position = pos;

        //float range = (maxX - minX);
        //tr.position = new Vector3( 
        //    MathHelper.MathMod((pos.x + (range / 2)),
        //                       range) -
        //        (range / 2),
        //    pos.y);
	}
}
public static class MathHelper
{
    public static float MathMod(float a, float b)
    {
        return (Mathf.Abs(a * b) + a) % b;
    }
}