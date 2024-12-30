using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartShooting
{

    namespace Playercolliders
    {

        namespace obstacleRotating
        {

            public class rotatingObstacle : MonoBehaviour
            {
                public Animator movingSpike;
                int countshot;
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {

                }

                private void OnCollisionEnter2D(Collision2D spikewihBullet)
                {
                    if (spikewihBullet.transform.tag == "bulletPlayer")
                    {
                        countshot++;
                        movingSpike.SetBool("offMove", true);
                        if (countshot == 1)
                        {
                            Destroy(spikewihBullet.gameObject);
                        }

                    }
                }


            }
        }
    }
}
