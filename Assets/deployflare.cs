using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployflare : MonoBehaviour
{
    [SerializeField]
    GameObject thingToSpawn;

    [SerializeField]
    Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(thingToSpawn, spawnpoint.position, Quaternion.identity);
        }
    }
}
