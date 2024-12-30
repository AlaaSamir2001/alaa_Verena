using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{

    namespace Bullets
    {
        namespace EnemyBULLETS
        {
            namespace updiagonalEnemyBULLETS
            {
                public class updiagonalBullet : MonoBehaviour
                {

                    public Vector3 UpdiagonalbulletEnemy;


                    // Start is called before the first frame update
                    void Start()
                    {

                        Destroy(gameObject, 2);
                    }

                    // Update is called once per frame
                    void Update()
                    {
                        upEnemyBullet();
                    }

                    void upEnemyBullet()
                    {

                        transform.position += UpdiagonalbulletEnemy * Time.deltaTime;

                    }
                }
            }
        }
    }
}
