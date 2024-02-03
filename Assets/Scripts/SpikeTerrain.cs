using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpikeTerrain : MonoBehaviour
{
    [SerializeField] int spikeDamage = 1;
    [SerializeField] int jumpForce = 300;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().ApllyDamage(spikeDamage);
        }

        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce);
    }
}
