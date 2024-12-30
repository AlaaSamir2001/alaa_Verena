using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{

    namespace Player
    {
        namespace PlayerJUMP
        {

            public class PlayerJUMPING : MonoBehaviour
            {
                public float jumpSpeed;
                public Animator Jumpstate;
                bool jumpFlag;
                int countJump = 0;

                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {
                    jumping();
                }


                //jumping Function
                void jumping() {
                    if (Input.GetKeyDown(KeyCode.Space) && jumpFlag) {

                        transform.Translate(0, jumpSpeed * Time.deltaTime, 0);
                        Jumpstate.SetBool("jump", true);
                        countJump++;
                        Debug.Log(countJump);
                        jumpFlag = false;
                        Debug.Log("Player is Jumping");


                    }
                    else if (Input.GetKeyUp(KeyCode.Space)) {
                        Jumpstate.SetBool("jump", false);
                    }

                    //Make the DoubleJump

                    else if (Input.GetKeyDown(KeyCode.Space) && !jumpFlag && countJump==1) {
                        Jumpstate.SetBool("jump", true);
                        transform.Translate(0, jumpSpeed * Time.deltaTime*2, 0);
                        countJump++;
                        Debug.Log(countJump);
                        Debug.Log("Player is Doubling Jump");
                        countJump = 0;
                    }
                   
                
                }

                private void OnCollisionEnter2D(Collision2D PlayerCollisionLand)
                {
                    if (PlayerCollisionLand.transform.tag == "Platform") {
                        jumpFlag = true;
                        countJump = 0; 
                        Debug.Log(countJump);
                        Debug.Log("Player is on Ground Now");
                    }
                }
            }
        }
    }
}
