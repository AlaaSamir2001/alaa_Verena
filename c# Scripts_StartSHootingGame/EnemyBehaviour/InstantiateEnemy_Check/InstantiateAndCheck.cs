using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//HERE I CHECK WHEN TO INSTATIATE AND STOP THE SAME INSTATIATE 
namespace StartShooting
{

    namespace enemies
    {
        namespace enemyInstantiate_check
        {
            public class InstantiateAndCheck : MonoBehaviour
            {

                //GREEN ENEMY
                public GameObject GreenEnemy;
                public Transform GreenEnemyPOS;

                //ORANGE ENEMY
                public GameObject OrangeEnemy;
                public Transform OrangeEnemyPOS;

                //BLUE ENEMY
                public GameObject BlueEnemy;
                public Transform BlueEnemyPOS;

                // this is check when enemy instantiated

                public GameObject player;


                //counting to stop Instatiate
                int greencounter;

                int orangecounter;
                int bluecounter;

                // Start is called before the first frame update
                void Start()
                {
                    InvokeRepeating("checkPOSforGreen", 5, 5);
                    InvokeRepeating("checkPOSforOrange", 5, 5);
                    InvokeRepeating("checkPOSforBlue", 5, 5);
                }

                // Update is called once per frame
                void Update()
                {
                    checkCountingforGreen();
                    checkCountingforOrange();
                    checkCountingforBlue();
                }



                //FOR GREEN ENEMY
                void checkPOSforGreen()
                {
                    if (player.transform.position.x > 21)
                    {

                        Instantiate(GreenEnemy, GreenEnemyPOS.position, Quaternion.identity);
                        greencounter++;
                        Debug.LogWarning(greencounter + " counting for green");
                    }
                }
                void checkCountingforGreen() {
                    if (greencounter==2) {
                        CancelInvoke("checkPOSforGreen");
                        Debug.LogWarning("green will not come again");
                        greencounter = 0;
                    }
                }



                //FOR ORANGE ENEMY
                void checkPOSforOrange() {
                    if (player.transform.position.x > 117)
                    {

                        Instantiate(OrangeEnemy, OrangeEnemyPOS.position, Quaternion.identity);
                        orangecounter++;
                        Debug.LogWarning(orangecounter+" counting for orange");
                    }
                }

                void checkCountingforOrange()
                {
                    if (orangecounter == 2)
                    {
                        CancelInvoke("checkPOSforOrange");
                        Debug.LogWarning("orange will not come again");
                        orangecounter = 0;
                    }
                }


                //FOR BLUE ENEMY

                void checkPOSforBlue()
                {
                    if (player.transform.position.x > 184)
                    {

                        Instantiate(BlueEnemy, BlueEnemyPOS.position, Quaternion.identity);
                        bluecounter++;
                        Debug.LogWarning(orangecounter + " counting for blue");
                    }
                }

                void checkCountingforBlue()
                {
                    if (bluecounter == 2)
                    {
                        CancelInvoke("checkPOSforBlue");
                        Debug.LogWarning("blue will not come again");
                        bluecounter = 0;
                    }
                }

            }


        
        }
    }
}

