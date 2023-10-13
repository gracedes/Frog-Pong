using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public Collider2D col;
    public float speedFactor;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(speedFactor * (Vector2.right + Vector2.up), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        checkCol();
    }

    public float rotCoeff;

    public void checkCol()
    {
        if (col.IsTouchingLayers(LayerMask.GetMask("wallUp"))) {
            rb.AddTorque(rotCoeff * (rb.velocity.x / Mathf.Abs(rb.velocity.y)), ForceMode2D.Impulse);   
        }
        else if (col.IsTouchingLayers(LayerMask.GetMask("wallDown")))
        {
            rb.AddTorque(-rotCoeff * (rb.velocity.x / Mathf.Abs(rb.velocity.y)), ForceMode2D.Impulse);
        }
    }
}
