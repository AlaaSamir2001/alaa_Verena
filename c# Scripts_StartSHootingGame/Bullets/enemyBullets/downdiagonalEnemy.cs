using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{

    namespace Bullets
    {
        namespace EnemyBULLETS
        {
            namespace downdiagonalEnemyBULLETS
            {
                public class downdiagonalEnemy : MonoBehaviour
                {

                    public Vector3 downdiagonalbulletEnemy;


                    // Start is called before the first frame update
                    void Start()
                    {

                        Destroy(gameObject, 2);
                    }

                    // Update is called once per frame
                    void Update()
                    {
                        downEnemyBullet();
                    }

                    void downEnemyBullet()
                    {

                        transform.position += downdiagonalbulletEnemy * Time.deltaTime;

                    }
                }
            }
        }
    }
}

