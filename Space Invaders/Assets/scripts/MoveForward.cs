using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float forwardSpeed;
    private Vector3 move = new Vector3(-1, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10 || transform.position.x > 10)
        {
            if (transform.position.x > 0 )
            {
                move.x = -1;
                transform.Translate(Vector2.down);
            }
            else if (transform.position.x < 0 )
            {
                move.x = 1;
                transform.Translate(Vector2.down);

            }
        }
        else if(transform.position.y <= -9 )
        {
            Destroy(gameObject);
        }
        transform.Translate(move * forwardSpeed*Time.deltaTime);
    }
  
}
