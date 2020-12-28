using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   /* private float timeBtwAttack;
    public float startTimeBtwAttack;*/

    public int health;

    public float speed;

    public GameObject deathEffect;

    public int damage;
    private float stoptime;
    public float startStoptime;
    public float normalSpeed;

    private Player player;

    private Animator anim;

    /*private void Start()
    {
        anim = GetComponent<Animator>();
        player = FindObjectOfType<Player>();
        normalSpeed = speed;
    }*/
    private void Update()
    {
       /* if (stoptime <= 0)
        {
            speed = normalSpeed;
        }
        else
        {
            speed = 0;
            stoptime -= Time.deltaTime;
        }*/
        if (health <= 0)
        {
            Destroy(gameObject);
        }

       /* transform.Translate(Vector2.left * speed * Time.deltaTime);*/
    }
    public void TakeDamage(int damage)
    {
       /* stoptime = startStoptime;*/
        health -= damage;

    }
    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (timeBtwAttack <= 0)
            {
                anim.SetTrigger("attack");

            }
            else
            {
                timeBtwAttack -= Time.deltaTime;
            }
        }
    }
    public void onEnemyAttck() 
    {
        Instantiate(deathEffect, player.transform.position, Quaternion.identity);
        player.helath -= damage;
        timeBtwAttack = startTimeBtwAttack;
    }*/


}
