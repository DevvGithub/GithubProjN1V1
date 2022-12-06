using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 50) * Time.deltaTime;
        Destroy(gameObject,3);
        //Movement + Livstid
    }
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject, 0);
            //Explanatory
        }
    }
}

