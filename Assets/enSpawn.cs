using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject thingToSpawn;

    [SerializeField]
    Transform spawnpoint;

    GameObject enemyobject;

    float timer = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(thingToSpawn, transform.position + new Vector3(Random.Range(-10,10),0,0), Quaternion.identity);
            timer = Random.Range(1, 3);
        }
        
    }
}