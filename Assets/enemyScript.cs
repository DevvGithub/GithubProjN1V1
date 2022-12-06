using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyScript : MonoBehaviour
{
    Rigidbody rbod;
    killManager kills;
    // Start is called before the first frame update
    void Start()
    {
        rbod = GetComponent<Rigidbody>();
        GameObject KillManager = GameObject.Find("Canvas");
        killManager kills = KillManager.GetComponent<killManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, 10) * Time.deltaTime;
        //Constant speed
    }
    private void OnTriggerEnter(Collider collision)
    {
        float torZ = Random.Range(-50f, 50f);
        float torY = Random.Range(0f, -50f);
        Destroy(gameObject, 15);

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0);
            //Crash
        }
        else if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject, 5);
            rbod.useGravity = true;
            rbod.AddTorque(new Vector3(0f, torY, torZ));
            rbod.AddForce(new Vector3(torZ, 0f, 0f));
            //Kill effect

            kills.playerscore = kills.playerscore + 1;
        }
    }
}
