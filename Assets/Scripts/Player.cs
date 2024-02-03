using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int HitPoints = 10;
    [SerializeField] float speed = 10;
    [SerializeField] float jumpForce = 250;
    private int canJump = 0;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovimentControll();
    }

    void MovimentControll()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float newXvalue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            this.transform.Translate(new Vector3(newXvalue, 0, 0));
            FlipPlayer();
        }
        if (Input.GetKeyDown("space") && canJump < 2)
        {
            print("jump");
            Jump();
        }
       
    }

    void FlipPlayer()
    {
        bool facingRight = transform.localScale.x > 0;
        bool movingRight = Input.GetAxis("Horizontal") > 0;

        if (facingRight != movingRight)
        {
            transform.localScale = new Vector3(-1 * transform.localScale.x,
                                                    transform.localScale.y,
                                                    transform.localScale.z);
        }
    }

    void Jump()
    {
        rb.AddForce(transform.up * jumpForce);
        canJump++;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            canJump = 0;
        }
    }

    public void ApllyDamage(int damage)
    {
        print("Damage applied on Player: " + damage);
        HitPoints -= damage;
    }
}
