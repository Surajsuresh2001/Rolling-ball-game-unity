using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecoin : MonoBehaviour
{
    public Text score;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
      ScoreNum = 100;
      score.text = "Score : " + ScoreNum; 
    }

    private void OnTriggerEnter(Collider coin)
    {
      if (coin.tag == "point")
      {
        ScoreNum += 10;
        Destroy(coin.gameObject);
        score.text = "Score :" + ScoreNum;
      }
    }

    
}