using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{
    namespace item
    {
        namespace healthPlayerIncrease
        {
            public class HealthIncreaser : MonoBehaviour
            {
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {

                }
                private void OnCollisionEnter2D(Collision2D incHealth)
                {
                    if (incHealth.transform.tag == "Player")
                    {
                        Destroy(gameObject);
                        Debug.Log("You have taken the Pineapple healthbar");
                    }
                }
            }
        }
    }
}