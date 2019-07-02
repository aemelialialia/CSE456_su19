using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 5;
    public Rigidbody rigid;
    public Animator anime;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        anime.SetBool("forward", false);
        anime.SetBool("backward", false);
		if (Input.GetKey(KeyCode.W))
        {
            //move up
            rigid.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
            anime.SetBool("forward", true);
            anime.SetBool("backward", false);
       
        } else if (Input.GetKey(KeyCode.S))
        {
            //move down
            rigid.MovePosition(transform.position + (-transform.forward) * speed * Time.deltaTime);
            anime.SetBool("forward", false);
            anime.SetBool("backward", true);
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
