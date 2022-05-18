using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefensiveController : MonoBehaviour
{
    GameObject shield;
    // Start is called before the first frame update
    void Start()
    {
        shield = GameObject.Find("Shield");
        shield.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D Col){
        if(Col.gameObject.tag == "ROBOT"){
            shield.gameObject.SetActive(true);
            shield.GetComponent<ShieldController> ().getDefensive();
        }
        Destroy(gameObject);    
        if(shield.GetComponent<Image>().fillAmount <= 0){
            shield.gameObject.SetActive(false);
        }
    }
}
