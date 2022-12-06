using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flarefunctionality : MonoBehaviour
{
    Rigidbody rbod;
    private float movementforce;
    // Start is called before the first frame update
    void Start()
    {
        rbod = GetComponent<Rigidbody>();
        movementforce = Random.Range(-500, 500);
        if (movementforce == 0)
        {
            movementforce = 500;
        }
        Destroy(gameObject, 2);
        rbod.AddForce(new Vector3(movementforce, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
