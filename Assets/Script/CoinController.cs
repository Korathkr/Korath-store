using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        
    }
    void OnCollisionEnter2D(Collision2D Col){
        GameObject score = GameObject.Find("score");
        if(Col.gameObject.tag == "ROBOT"){
            score.GetComponent<ScoreController> ().ScoreControl();
        }
       Destroy(gameObject); 
    }
}

