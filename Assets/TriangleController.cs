using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleController : MonoBehaviour

{
    public Rigidbody2D myrigidbody;
    public float movespeed = .001f;
    public float jumpforce = 1f;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(3, 0));

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            //transform.position = transform.position + new Vector3( 0, movespeed);
            myrigidbody.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            // transform.position = transform.position + new Vector3(-movespeed, 0);
            myrigidbody.AddForce(new Vector2(-movespeed, 0));
        }
        //if (Input.GetKey(KeyCode.S))
        //{
        //    // transform.position = transform.position + new Vector3(0, -movespeed);
        //    myrigidbody.AddForce(new Vector2(0, -movespeed));
        //}
        if (Input.GetKey(KeyCode.D))
        {
            // transform.position = transform.position + new Vector3(movespeed, 0);
            myrigidbody.AddForce(new Vector2(movespeed, 0));
        }
    }

    //for floor detection
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 6)
        {
            isGrounded = true;
        }

    }

}
