using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartShooting
{

    namespace Player
    {
        namespace PlayerMovement
        {
            public class MovingPlayer : MonoBehaviour
            {

                public float velocity;

                public Animator WALKstate;

                
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {
                    movingPLAYER();
                }

                void movingPLAYER()
                {


                    // NOTIFICATION :- I used (GetKey) because i want player to move while holding the key
                    ////////////////////
                    ///

                    //MOVING RIGHT

                    if (Input.GetKey(KeyCode.RightArrow))
                    {

                        WALKstate.SetBool("walk", true);
                        GetComponent<SpriteRenderer>().flipX = false;
                        transform.position += new Vector3(velocity * Time.deltaTime, 0, 0);
                    }
                    else if (Input.GetKeyUp(KeyCode.RightArrow))
                    {
                        WALKstate.SetBool("walk", false);


                    }

                    //MOVING LEFT

                    if (Input.GetKey(KeyCode.LeftArrow))
                    {

                        WALKstate.SetBool("walk", true);
                        GetComponent<SpriteRenderer>().flipX = true;
                        transform.position += new Vector3(velocity * Time.deltaTime * -1, 0, 0);
                    }
                    else if (Input.GetKeyUp(KeyCode.LeftArrow))
                    {
                        WALKstate.SetBool("walk", false);


                    }
                }
            }
        }
    }
}
