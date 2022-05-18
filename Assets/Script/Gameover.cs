using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("function_Start", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void function_Start(){
        SceneManager.LoadScene("Start");
    }
}
