using UnityEngine;
using System.Collections;

public class DiveonDown : MonoBehaviour
{

    public Vector2 downSpeed;
    Rigidbody2D rb;
    public KeyCode left;
    public KeyCode right;
    public float bigMass;
    public float littleMass;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left) && Input.GetKey(right))
        {
            rb.AddForce(downSpeed);
            rb.mass = bigMass;
        }
        else { rb.mass = littleMass; }
    }
}
