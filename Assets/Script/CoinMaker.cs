using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMaker : MonoBehaviour
{   
    public GameObject CoinPrefab;
    float interval = 1.2f;
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
            GameObject Coin = Instantiate(CoinPrefab);

            //x좌표 난수로 반복
            int x = Random.Range(-8, 9);

            //랜덤한 x좌표에서 생성
            Coin.transform.position = new Vector3(x, 6, 0);
        }
    }
}
