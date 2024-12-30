using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartShooting
{

    namespace Playercolliders
    {

        namespace bouncingPlatform
        {
            public class bouncyplatform : MonoBehaviour
            {
                public Animator bounce;
               public GameObject character;
                int counting;

                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {
                    checkingPOs();
                }
                private void OnCollisionEnter2D(Collision2D collideWithBouncy)
                {
                    if (collideWithBouncy.transform.tag == "Player")
                    {
                        bounce.SetBool("bouncJump", true);
                        Debug.LogError("Player Bouncing");

                       

                    }

                }
                private void OnCollisionExit2D(Collision2D notcollide)
                {
                    
                    if
                    (notcollide.transform.tag == "Player")
                    {
                        counting++;
                        if (counting==2) {
                         
                        }


                    }
                }
                void checkingPOs() {

                    if (character.transform.position.y > 2)
                    {
                        bounce.SetBool("bouncJump", false);
                        Debug.LogWarning("Player Not Bouncing");
                    }


                }
            }
	

            
        }
    }
}