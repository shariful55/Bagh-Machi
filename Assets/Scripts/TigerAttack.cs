using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerAttack : MonoBehaviour
{

    public GameObject [] Flies;

    public enum AttackCondition { silent,move, attack};

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;

            if (touch.phase == TouchPhase.Began)
            {
               // if(touchPosition==Fly.transform.position)

                if (touchPosition.x>-1&& touchPosition.x<1&&touchPosition.y>2&& touchPosition.y<4)
                {
                    Flies[0].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                    Flies[1].gameObject.GetComponent<SpriteRenderer>().color = Color.red;

                }


            }

            if (touch.phase == TouchPhase.Ended)
            {
                Flies[0].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                Flies[1].gameObject.GetComponent<SpriteRenderer>().color = Color.white;

                if(this.transform.position==new Vector3(0, 3, 0))
                {
                if (touchPosition.x > -1 && touchPosition.x < 1 && touchPosition.y > -4 && touchPosition.y < -2)
                    {
                        Flies[0].gameObject.SetActive(false);

                        this.transform.position = new Vector3(0, -3, 0);
                    }

                }


            }




        }
    }
}
