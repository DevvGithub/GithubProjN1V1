using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rbod;

    // Start is called before the first frame update
    void Start()
    {
        rbod = GetComponent<Rigidbody>();
        //Rigidbody
    }

    // Update is called once per frame
    void Update()
    {

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, Mathf.Clamp(transform.eulerAngles.z, 30f, 120f));

        if (Input.GetKey(KeyCode.D))
        {
            rbod.AddForce(new Vector3(2f, 0f, 0f));
            transform.eulerAngles -= new Vector3(0, 0, 15) * Time.deltaTime;
            //MovementD
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rbod.AddForce(new Vector3(-2f, 0f, 0f));
            transform.eulerAngles += new Vector3(0, 0, 15) * Time.deltaTime;
            //MovementA
        }
    }
}
