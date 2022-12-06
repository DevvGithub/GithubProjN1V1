using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class killManager : MonoBehaviour
{
    public int playerscore = 0;
    TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Enemy = GameObject.Find("Enemy");
        enemyScript enemyScript = Enemy.GetComponent<enemyScript>();
        scoreText = GameObject.Find("KillUI").GetComponent<TextMeshProUGUI>();
        scoreText.text = "Fat: " + playerscore;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
