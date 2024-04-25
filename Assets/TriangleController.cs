using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleController : MonoBehaviour
{
    public float movespeed = .001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(3, 0));
        
        if (Input.GetKey ( KeyCode.W )) 
        {
            transform.position = transform.position + new Vector3( 0, movespeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-movespeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, -movespeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(movespeed, 0);
        }
    }
}
