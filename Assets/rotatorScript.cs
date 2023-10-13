using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatorScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public string upKey;
    public string downKey;
    public float maxRot;
    public float rotSpeed;

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
        if (Input.GetKey(upKey) && rb.rotation < maxRot)
        {
            rb.MoveRotation(rb.rotation + (Time.deltaTime * rotSpeed));
        }

        if (Input.GetKey(downKey) && rb.rotation > -maxRot)
        {
            rb.MoveRotation(rb.rotation - (Time.deltaTime * rotSpeed));
        }
    }
}
