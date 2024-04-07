using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
      ScoreNum = 100;
      score.text = "Score : " + ScoreNum; 
    }

    private void OnTriggerEnter(Collider Cube)
    {
      if (Cube.tag == "coin")
      {
        ScoreNum -= 10;
        Destroy(Cube.gameObject);
        score.text = "Score :" + ScoreNum;
      }
    }

    
}