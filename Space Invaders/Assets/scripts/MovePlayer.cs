using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovePlayer : MonoBehaviour
{
    public GameObject projectile;
    public float speed;
    public float input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (System.MathF.Abs(transform.position.x) > 11)
        {
            if (transform.position.x < 0)
                transform.position = new Vector3(-11, -9,0);
            else
                transform.position = new Vector3(11, -9, 0);
        }
        else
        {
            input = Input.GetAxis("Horizontal");
            transform.position += new Vector3(speed, 0, 0) 
                * Time.deltaTime * input;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position , transform.rotation);
        }
    }
}
