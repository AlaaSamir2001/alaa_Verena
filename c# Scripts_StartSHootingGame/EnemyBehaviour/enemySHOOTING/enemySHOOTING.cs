using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StartShooting.Bullets.PlayerBULLETS;

namespace StartShooting
{

    namespace Enemy
    {
        namespace enemyshooting
        {

            public class enemySHOOTING : MonoBehaviour
            {
                

                public GameObject BulletEnemy;
                public Transform BulletEnemyPOS;

               


                // Start is called before the first frame update
                void Start()
                {
                    InvokeRepeating("enemyShooting", .5f, .5f);
                }

                // Update is called once per frame
                void Update()
                {
                   
                }

                void enemyShooting()
                {
                    
                        Instantiate(BulletEnemy, BulletEnemyPOS.position, Quaternion.identity);
                    

                 

                   
                }
            }
        }
    }
}
