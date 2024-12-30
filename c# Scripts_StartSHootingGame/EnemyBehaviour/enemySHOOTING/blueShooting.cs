using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{

    namespace Enemy
    {
        namespace enemyshooting
        {
            namespace blue__enemyshooting
            {

                public class blueShooting : MonoBehaviour
            {

                //HORIZONTAL BULLET
                public GameObject BulletEnemy;
                public Transform BulletEnemyPOS;

                //UPDIAGONAL

                public GameObject UPBulletEnemy;
                public Transform UPBulletEnemyPOS;

                //DOWNDIAGONAL


                public GameObject DOWNBulletEnemy;
                public Transform DOWNBulletEnemyPOS;

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

                    Instantiate(UPBulletEnemy, UPBulletEnemyPOS.position, Quaternion.identity);
                    Instantiate(BulletEnemy, BulletEnemyPOS.position, Quaternion.identity);
                    Instantiate(DOWNBulletEnemy, DOWNBulletEnemyPOS.position, Quaternion.identity);




                }
            }
        }
    }
}
}

