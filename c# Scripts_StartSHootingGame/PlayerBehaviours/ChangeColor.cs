using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS SCRIPT WHEN CHANGING COLOR OF PLAYER

namespace StartShooting
{

    namespace Player
    {
        namespace Player_Item
        {
            namespace ChangeColorToRed
            {
                public class ChangeColor : MonoBehaviour
                {
                    public GameObject RedItem;
                    public Transform reditemPOS;
                    // Start is called before the first frame update
                    void Start()
                    {
                        Instantiate(RedItem, reditemPOS.position, Quaternion.identity);
                    }

                    // Update is called once per frame
                    void Update()
                    {

                    }

                    
                    /// //////////////////////////
                    
                    /// <param name="changecolor"></param>
                    private void OnCollisionEnter2D(Collision2D changecolor)
                    {
                        if (changecolor.transform.tag == "ItemColorChanging")
                        {
                            GetComponent<SpriteRenderer>().color = Color.red;
                            Destroy(changecolor.gameObject);
                            Invoke("returnDefaultColor", 10);
                        }
                    }
                    void returnDefaultColor()
                    {
                        GetComponent<SpriteRenderer>().color = Color.white;
                        Instantiate(RedItem, reditemPOS.position, Quaternion.identity);
                        Debug.Log("Player now is Back to Default Color if You want to turn red go to same place of red item");
                        
                    }
                }
            }
        }
    }
}
