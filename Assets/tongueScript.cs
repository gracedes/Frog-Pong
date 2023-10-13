using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class tongueScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public string shootKey;
    public float tongueSpeed;
    public float returnMulti;
    public Vector2 velo;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkInput();
    }

    public void checkInput()
    {
        if (Input.GetKeyDown(shootKey))
        {
            velo = new Vector2((float)tongueSpeed * (float)Math.Cos(rb.rotation * (Math.PI / 180)), (float)tongueSpeed * (float)Math.Sin(rb.rotation * (Math.PI / 180)));
            print(Math.Cos(rb.rotation * (180 / Math.PI)));
            print(Math.Sin(rb.rotation * (180 / Math.PI)));
            shoot(velo);
        }
        if (Input.GetKeyUp(shootKey))
        {
            returnTongue(velo);
        }
    }

    public void shoot(Vector2 velo)
    {
        rb.velocity = velo;
    }

    public void returnTongue(Vector2 velo)
    {
        rb.velocity = - velo * returnMulti;
    }
}
