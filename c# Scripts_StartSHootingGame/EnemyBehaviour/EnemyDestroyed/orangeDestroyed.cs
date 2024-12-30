using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS FOR DESTROYING GREEN ENEMY
namespace StartShooting
{

    namespace Enemy
    {
        namespace orangeenemydead
        {
            public class orangeDestroyed : MonoBehaviour
            {
                public Animator deadOrange;
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {

                }

                private void OnTriggerEnter2D(Collider2D dead_orange)
                {
                    if (dead_orange.transform.tag == "bulletPlayer")
                    {
                        deadOrange.SetBool("orangeDead", true);
                        Destroy(gameObject, 1);
                        Destroy(dead_orange.gameObject);
                    }
                }
            }
        }
    }
}
