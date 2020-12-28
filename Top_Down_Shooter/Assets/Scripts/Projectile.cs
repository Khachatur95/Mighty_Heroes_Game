using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 4;



    public  void Update()
    {
        transform.position += -transform.right * Speed * Time.deltaTime;
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         var enemy =  collision.collider.GetComponent<EnemyBehaviour>();
        if (enemy)
        {
            enemy.TakeHit(1);
        }
        Destroy(gameObject);
    }
}
