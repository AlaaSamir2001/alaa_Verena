using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartShooting
{

    namespace ObstacleCase
    {
        namespace instantiateSPIKES
        {
            public class InstantiateSpike : MonoBehaviour
            {

                public GameObject character_;
                int stCounter;
                int finalCounter;
                //HORIZONTALSPIKE
                public GameObject horizontalSpike;
                public Transform horizontalSpikePOS;

                //UPDIAGONALSPIKE
                public GameObject updiagnoalSpike;
                public Transform updiagnoalSpikePOS;

                //DOWNDIAGONAL
                public GameObject downdiagnoalSpike;
                public Transform downdiagnoalSpikePOS;

                // Start is called before the first frame update
                void Start()
                {
                    InvokeRepeating("checkingPOs", 3, 3);
                    InvokeRepeating("checkposFinal", 3, 3);
                }

                // Update is called once per frame
                void Update()
                {
                    chekstCount();
                    checkfinalcount();
                }
                void checkingPOs()
                {
                    if (character_.transform.position.x > 253)
                    {
                        Instantiate(horizontalSpike, horizontalSpikePOS.position, Quaternion.identity);
                        Instantiate(updiagnoalSpike, updiagnoalSpikePOS.position, Quaternion.identity);
                        stCounter++;

                    }
                }

                //COUNTING FOR APPEARANCE
                void chekstCount()
                {
                    if (stCounter == 3)
                    {
                        CancelInvoke("checkingPOs");
                        stCounter = 0;
                    }
                }

                //THIS TO SPAWN DOWNDIAGONAL SPIKE AT LAST STAGE BEFORE BEAST
                void checkposFinal()
                {
                    if (character_.transform.position.x > 339)
                    {

                        Instantiate(downdiagnoalSpike, downdiagnoalSpikePOS.position, Quaternion.identity);
                        finalCounter++;
                    }
                }

                //COUNTING FOR APPEARANCE AT FINAL
                void checkfinalcount()
                {
                    if (finalCounter == 3)
                    {
                        CancelInvoke("checkposFinal");
                        finalCounter = 0;
                    }
                }
            }
        }
    }
}
