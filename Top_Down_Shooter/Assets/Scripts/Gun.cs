﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public Transform shotpoint;

    private float timeBtwShots;
    public float StartTimeBtwShots ;

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);


        if (timeBtwShots <= 0)
        {

            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, shotpoint.position, transform.rotation);
                timeBtwShots = StartTimeBtwShots;
            }

            else
            {
                timeBtwShots -= Time.deltaTime;
            }

        }


    }
}
