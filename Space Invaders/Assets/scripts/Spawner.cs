using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies = new GameObject[2];
    public int count=0;

    // Start is called before the first frame update
    void Start()
    {
          InvokeRepeating("Spawn", 0, 2);
          count= 0;
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    void Spawn()
    {
        Vector3 randomPos = new Vector3(9.98f, 0, 0);
        // GameObject randomAnimal = animals[Random.Range(0, 1)];

        
        Instantiate(enemies[0], randomPos, Quaternion.Euler(new Vector3(0, 0, 0)));
        inc();

        if (count == 5  )
        {
            Instantiate(enemies[1], randomPos, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
    }
    public void inc()
    {
        count += 1;
        Debug.Log(count);
    }
}
