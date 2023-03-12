using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            if (health == 0)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
                Time.timeScale = 0;
            }
            else
            {
                Destroy(collision.gameObject);
                health--;

            }
            //Debug.Log(health + " boss");
        }
    }
    
}
