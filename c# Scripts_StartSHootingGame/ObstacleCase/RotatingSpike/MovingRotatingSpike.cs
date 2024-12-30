using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartShooting
{

    namespace ObstacleCase
    {
        namespace rotatingSpikes
        {
            public class MovingRotatingSpike : MonoBehaviour
            {
                public Vector3 SpikeSpeed;
                // Start is called before the first frame update
                void Start()
                {
                    Destroy(gameObject,5);

                }

                // Update is called once per frame
                void Update()
                {
                    movingSpike();
                }

                void movingSpike()
                {
                    transform.position += SpikeSpeed * Time.deltaTime;

                }
            }
        }
    }
}
