using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{



    /*private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemy;

    public float attackRange;
    public int damage;*/

    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        /*Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);*/


      /*  if (timeBtwAttack <= 0)
        {

            if (Input.GetMouseButton(0))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position,attackRange,whatIsEnemy);
                for (int i = 0; i <enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
               
            }
            timeBtwAttack = startTimeBtwAttack;



        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }

    }
*/
    /*public  void onAttack() 
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemy);
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].GetComponent<Enemy>().TakeDamage(damage);
        }

    }
     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position,attackRange);
    }*/
   
}
    void Attack()
    {
        anim.SetTrigger("attack");
    }
}
