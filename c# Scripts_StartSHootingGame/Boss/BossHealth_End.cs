using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{
    namespace Boss
    {
        namespace BossHealth
        {
            public class BossHealth_End : MonoBehaviour
            {
                int BOSSHEALTH = 20;

                //TO INSTANTIATE FLAG ENDINGLEVEL
                public GameObject flagEnding;
                public Transform flagEndingPOS;
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {

                }
                private void OnTriggerEnter2D(Collider2D decreaseBossHealth)
                {
                    if (decreaseBossHealth.transform.tag=="bulletPlayer") {
                        BOSSHEALTH--;
                        Debug.LogWarning("Boss decreasing now his health is "+ BOSSHEALTH);
                    }
                    if (BOSSHEALTH==0) {
                        Destroy(gameObject);
                        Instantiate(flagEnding, flagEndingPOS.position,Quaternion.identity);
                    }
                }
            }
        }
    }
}
