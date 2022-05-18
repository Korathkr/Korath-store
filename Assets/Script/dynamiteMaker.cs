using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamiteMaker : MonoBehaviour
{   
    public GameObject dmPrefab;
    float interval = 1.0f;
    float delta = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > interval){
            delta = 0;
            //프리팹 생성
            GameObject dynamite = Instantiate(dmPrefab);

            //x좌표 난수로 반복
            float x = Random.Range(-8.5f, 8.5f);

            //랜덤한 x좌표에서 생성
            dynamite.transform.position = new Vector3(x, 6, 0);
        }
    }
}
