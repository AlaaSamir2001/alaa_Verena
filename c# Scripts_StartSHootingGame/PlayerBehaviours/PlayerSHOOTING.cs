using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StartShooting.Bullets.PlayerBULLETS;

namespace StartShooting
{

    namespace Player
    {
        namespace Playershoot
        {

            public class PlayerSHOOTING : MonoBehaviour
            {
                
                //RightBullet
              public  GameObject RightBulletPlayer;
              public  Transform RightBulletPlayerPOS;


                //LeftBullet
                public GameObject leftBulletPlayer;
                public Transform leftBulletPlayerPOS;


                public Animator ShootState;


                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {
                    shooter();
                }

                void shooter() {
                    if (GetComponent<SpriteRenderer>().flipX == false && Input.GetKeyDown(KeyCode.Z)) {
                        ShootState.SetBool("shoot", true);
                        Instantiate(RightBulletPlayer, RightBulletPlayerPOS.position, Quaternion.identity);
                    }

                   
                    if (GetComponent<SpriteRenderer>().flipX == true && Input.GetKeyDown(KeyCode.Z))
                    {
                        ShootState.SetBool("shoot", true);
                        Instantiate(leftBulletPlayer, leftBulletPlayerPOS.position, Quaternion.identity);
                    }

                    else if (Input.GetKeyUp(KeyCode.Z))
                    {
                        ShootState.SetBool("shoot", false);
                    }
                }
            }
        }
    }
}
