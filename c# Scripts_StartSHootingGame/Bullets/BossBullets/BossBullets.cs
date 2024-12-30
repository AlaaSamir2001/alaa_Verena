using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{
    namespace Bullets
    {
        namespace BossBullet
        {
            public class BossBullets : MonoBehaviour
            {
                public Vector3 bossbulletspeed;
                // Start is called before the first frame update
                void Start()
                {
                    Destroy(gameObject, 3);
                }

                // Update is called once per frame
                void Update()
                {
                    movingBossBullets();
                }
              void  movingBossBullets() {
                    transform.position += bossbulletspeed * Time.deltaTime;
                }
            }
        }
    }
}
