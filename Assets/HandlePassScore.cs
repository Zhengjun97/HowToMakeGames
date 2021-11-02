using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandlePassScore : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject[] obstacles;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "CountScore")
        {
            scoreText.text = (score++).ToString();
            obstacles[score-1].GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
           
    }
}
