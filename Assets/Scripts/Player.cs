using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 5;
    public Rigidbody rigid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            //move up
            rigid.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.S))
        {
            //move down
            rigid.MovePosition(transform.position + (-transform.forward) * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigid.MovePosition(transform.position + (-transform.right) * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigid.MovePosition(transform.position + (transform.right) * speed * Time.deltaTime);
        }
	}
}
