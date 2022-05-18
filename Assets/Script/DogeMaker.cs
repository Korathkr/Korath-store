using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogeMaker : MonoBehaviour
{
    public GameObject DogePrefab;
    float interval = 12.0f;
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
            GameObject Doge = Instantiate(DogePrefab);

            //x좌표 난수로 반복
            float x = Random.Range(-8.5f, 8.5f);

            //랜덤한 x좌표에서 생성
            Doge.transform.position = new Vector3(x, 6, 0);
        }
    }
}
