using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dynamiteController : MonoBehaviour
{
    GameObject shield;
    // Start is called before the first frame update
    void Start()
    {
        shield = GameObject.Find("Shield");
    }

    // Update is called once per frame
    void Update() 
    {

    }
    void OnCollisionEnter2D(Collision2D Col){
        GameObject hp = GameObject.Find("HP"); 

        if(Col.gameObject.tag == "ROBOT"){
                if(shield.gameObject.activeSelf == true){
                    shield.GetComponent<ShieldController>().Defensive();
                }
                else if(shield.gameObject.activeSelf == false){
                    hp.GetComponent<hpController> ().HpControl();
                }
            }
            Destroy(gameObject);
        }
    }
