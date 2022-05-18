using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    Text score;
    public static int scoresum;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoresum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreControl(){
        scoresum += 10;
        score.text = "Score : " + (int) scoresum;
    }

    //충돌 시 스코어 0점
    public void Doge(){
        scoresum = 0;
        score.text = "Score : " + (int) scoresum;
    }
}

