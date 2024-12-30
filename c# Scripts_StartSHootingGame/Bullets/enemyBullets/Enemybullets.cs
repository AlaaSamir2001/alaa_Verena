using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{

    namespace Bullets
    {
        namespace EnemyBULLETS
        {
            public class Enemybullets : MonoBehaviour
            {

                public float bulletspeed;


                // Start is called before the first frame update
                void Start()
                {

                    Destroy(gameObject, 2);
                }

                // Update is called once per frame
                void Update()
                {
                    speedEnemyBullet();
                }

                void speedEnemyBullet()
                {

                    transform.Translate(bulletspeed * Time.deltaTime*-1, 0, 0);
                   
                }
            }
        }
    }
}
