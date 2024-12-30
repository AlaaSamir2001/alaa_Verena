using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//HERE I CHECK WHEN GAME ENDS IF PLAYER DROPPED FAR DOWN

namespace StartShooting
{

    namespace platform
    {
        namespace platformTocheckDeath
        {
            public class landCheckDeath : MonoBehaviour
            {
                public GameObject Player__;
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {
                    checkplayerPOS();
                }
                void checkplayerPOS(){
                    if (Player__.transform.position.y<-5) {
                        Destroy(Player__);
                        Debug.Log("You are dead, try again playing");
                    }
}
            }
        }
    }
}
