using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoring : MonoBehaviour
{
    int touchFlag;
    int touchCoin;
    int touchCup;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckLevelEnd();
    }
    private void OnCollisionEnter2D(Collision2D flagANdcup)
    {
        if (flagANdcup.transform.tag=="flagrecorder") {
            touchFlag++;
            Debug.LogWarning("you touched"+ "flag number " + touchFlag);
            Destroy(flagANdcup.gameObject);
        }

        //FOR CUP
        if (flagANdcup.transform.tag == "CupEnding") {
            touchCup++;
            Destroy(flagANdcup.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.transform.tag == "Coins")
        {
            touchCoin++;
            Debug.LogWarning("you touched" + "Coin Number " + touchCoin);
            Destroy(coin.gameObject);
        }
    }

    void CheckLevelEnd() {
        if (touchCoin==15 && touchFlag==5 && touchCup==1) {
            Debug.LogWarning("CONGRATULATION , YOU COMPLETED THE LEVEL");
            Destroy(gameObject);
        }
    }
}
