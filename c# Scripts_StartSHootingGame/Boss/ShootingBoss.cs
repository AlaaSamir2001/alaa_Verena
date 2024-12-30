using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartShooting
{
    namespace Boss
    {
        namespace shootingBoss
        {
            public class ShootingBoss : MonoBehaviour
            {
                public GameObject BulletBoss;
                public Transform BulletBossPOS;

                //UpDiagonal
                public GameObject updiagonalBulletBoss;
                public Transform updiagonalBulletBossPOS;

                //DownDiagonal
                public GameObject downdiagonalBulletBoss;
                public Transform downdiagonalBulletBossPOS;
                // Start is called before the first frame update
                void Start()
                {
                    InvokeRepeating("shootingBoss", 1, 1);
                }

                // Update is called once per frame
                void Update()
                {
                   
                }

                void shootingBoss() {
                    Instantiate(BulletBoss, BulletBossPOS.position, Quaternion.identity);
                    Instantiate(updiagonalBulletBoss, updiagonalBulletBossPOS.position, Quaternion.identity);
                    Instantiate(downdiagonalBulletBoss, downdiagonalBulletBossPOS.position, Quaternion.identity);
                }
            }
        }
    }
}
