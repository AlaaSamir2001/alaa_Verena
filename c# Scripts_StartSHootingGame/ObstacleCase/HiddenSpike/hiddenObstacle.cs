using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Playercolliders
{

    namespace ObstacleCase
    {
        namespace hiddenSpikes
        {


            public class hiddenObstacle : MonoBehaviour
            {

                int countsec;
                // Start is called before the first frame update
                void Start()
                {
                    InvokeRepeating("hidSpike",3,5);
                    
                }

                // Update is called once per frame
                void Update()
                {

                }

                void hidSpike()
                {
                    GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .5f);
                    countsec++;
                    if (countsec%3==0) {
                        GetComponent<SpriteRenderer>().color = Color.white;
                    }

                }
               
            }
        }
    }
}
