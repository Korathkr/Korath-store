using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamiteController : MonoBehaviour
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
        GameObject hp = GameObject.Find("HP");
        if(Col.gameObject.tag == "ROBOT"){
            hp.GetComponent<hpController> ().HpControl();
        }
        Destroy(gameObject);
    }
}
