using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{

    namespace Player
    {
        namespace PlayerhealthPoints
        {
            public class PlayerHealth : MonoBehaviour
            {

                int Player_Health = 20;
                public Animator DeadState;

                // Start is called before the first frame update
                void Start()
                {
                    Debug.Log("Now PlayerHealth is " + Player_Health);
                }

                // Update is called once per frame
                void Update()
                {
                    CheckHealth();
                }
                private void OnCollisionEnter2D(Collision2D healthDecrease)
                {
                    if (healthDecrease.transform.tag == "Obstacle"
                        || healthDecrease.transform.tag == "Enemy" )
                    {

                        Player_Health--;

                        Debug.Log("Your health decreased and now it's  " + Player_Health);
                    }

                   

                }
                private void OnTriggerEnter2D(Collider2D healthbar)
                {
                    if (healthbar.transform.tag == "ItemHealthIncrease" && Player_Health < 20)
                    {
                        Player_Health++;
                        Destroy(healthbar.gameObject);

                        Debug.Log("Your health Increased and now it's  " + Player_Health);
                    }
                    if (healthbar.transform.tag == "ObstacleTrigger" || healthbar.transform.tag == "enemyBullet")
                    {
                        Player_Health--;
                        Debug.Log("Your health decreased and now it's  " + Player_Health);


                    }

                }
                void CheckHealth()
                {
                    if (Player_Health == 0)
                    {
                        DeadState.SetBool("dead", true);
                        Debug.Log("Oah, You are dead now , try playing again");
                    }
                }


            }
        }
    }
}
