using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS FOR DESTROYING GREEN ENEMY
namespace StartShooting
{

    namespace Enemy
    {
        namespace greenenemydestroying
        {
            public class EnemyDestroyed : MonoBehaviour
            {
                public Animator deadGreen;
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {

                }

                private void OnTriggerEnter2D(Collider2D deadenemy)
                {
                    if (deadenemy.transform.tag=="bulletPlayer") {
                        deadGreen.SetBool("greenDead",true);
                        Destroy(gameObject,1);
                        Destroy(deadenemy.gameObject);
                    }
                }
            }
        }
    }
}
