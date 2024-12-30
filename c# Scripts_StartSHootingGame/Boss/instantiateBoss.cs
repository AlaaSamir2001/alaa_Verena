using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{
    namespace Boss
    {
        namespace instatiateboss
        {

            public class instantiateBoss : MonoBehaviour
            {


                public GameObject characteR;
                int count;

                //Boss
                public GameObject Boss;
                public Transform BossPOS;
                // Start is called before the first frame update
                void Start()
                {
                    
                    InvokeRepeating("checkerPOs", 3, 3);
                }

                // Update is called once per frame
                void Update()
                {
                    stopInstatiate();
                }
                void checkerPOs()
                {
                    if (characteR.transform.position.x > 338)
                    {
                        Instantiate(Boss, BossPOS.position, Quaternion.identity);
                        count++;
                    }
                }

                void stopInstatiate()
                {
                    if (count == 1)
                    {
                        CancelInvoke("checkerPOs");
                        Debug.LogError("InstatiateEnemyJustOnce");
                        count = 0;
                    }
                }
            }
        }
    }
}