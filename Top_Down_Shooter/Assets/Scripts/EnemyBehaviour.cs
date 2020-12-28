using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float hitpoints;
    public float maxhitpoints = 5;

    private void Start()
    {
        hitpoints = maxhitpoints;
    }

    public void TakeHit(float damage)
    {
        hitpoints -= damage;
        if (hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

}
