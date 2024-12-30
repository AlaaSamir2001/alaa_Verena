using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{

    namespace Bullets
    {
        namespace PlayerBULLETS
        {
            public class playerBUllet : MonoBehaviour
            {

               public float bulletSpeeding;
                
                
                // Start is called before the first frame update
                void Start()
                {
                    Destroy(gameObject, 7);
                }

                // Update is called once per frame
                void Update()
                {
                    speedBullet();
                }

               void speedBullet() {
                     
                    transform.Translate(bulletSpeeding * Time.deltaTime, 0, 0);

                }
            }
        }
    }
}
