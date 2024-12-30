using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS FOR DESTROYING BLUE ENEMY
namespace StartShooting
{

    namespace Enemy
    {
        namespace blue_enemydead
        {
            public class BlueDestroyed : MonoBehaviour
            {
                public Animator deadblue;
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {

                }

                private void OnTriggerEnter2D(Collider2D dead_blue)
                {
                    if (dead_blue.transform.tag == "bulletPlayer")
                    {
                        deadblue.SetBool("blueDead", true);
                        Destroy(gameObject, 1);
                        Destroy(dead_blue.gameObject);
                    }
                }
            }
        }
    }
}

