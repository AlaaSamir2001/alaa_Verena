using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartShooting
{
    namespace item
    {
        namespace lastFlag
        {
            public class LastFlag : MonoBehaviour
            {
                public GameObject Cup;
                public Transform CupPos;
                // Start is called before the first frame update
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {

                }
                private void OnCollisionEnter2D(Collision2D lastStage)
                {
                    if (lastStage.transform.tag == "Player")
                    {
                        Instantiate(Cup, CupPos.position, Quaternion.identity);
                    }
                }
            }
        }
    }
}
