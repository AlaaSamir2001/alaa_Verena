using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartShooting
{

    namespace enemies
    {
        namespace enemyMoving
        {
            public class enemyMOVING : MonoBehaviour
            {
                public Vector3 speedenemy;
               
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {
                    moveEnemy();
                }
                void moveEnemy() {
                    transform.position += speedenemy * Time.deltaTime;
                    Destroy(gameObject,10);
                }
               
            }
        }
    }
}
