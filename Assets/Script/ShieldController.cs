using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldController : MonoBehaviour
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
    public void getDefensive(){
        shield.GetComponent<Image>().fillAmount = 1;
    }
    public void Defensive(){
        shield.GetComponent<Image>().fillAmount -= 0.25f;
    }
}
