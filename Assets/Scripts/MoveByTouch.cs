using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveByTouch : MonoBehaviour
{
    private Vector3 PlayerPosition;

    private Transform PreviousPosition;
    private Transform CurrentPosition;

    void Start()
    {
        

    }
   
    void Update()
    {
        if (Input.touchCount > 0)
        {
            PlayerPosition = transform.position;
            Touch touch = Input.GetTouch(0);
            
            Vector3 touchPosition= Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
           
            
          
            if (touch.phase==TouchPhase.Began)
            {
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

               
            }
            if (touch.phase==TouchPhase.Moved)
            {
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

               
            }

            if (touch.phase == TouchPhase.Ended)
            {
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;

                
                
                    if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > -0.2f && touchPosition.y < 0.2f)
                    {
                        if (PlayerPosition == new Vector3(1.5f, 0, 0))
                        {
                            transform.position = new Vector3(0, 0, 0);
                        }

                        else
                        {
                            transform.position = this.transform.position; 
                        }

                    }

                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > -0.2f && touchPosition.y < 0.2f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 0, 0))
                    {
                        transform.position = new Vector3(0, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position; 
                    }

                }

                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > -0.2f && touchPosition.y < 0.2f)
                {
                    if (PlayerPosition == new Vector3(0, 1.5f, 0))
                    {
                        transform.position = new Vector3(0, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > -0.2f && touchPosition.y < 0.2f)
                {
                    if (PlayerPosition == new Vector3(0, -1.5f, 0))
                    {
                        transform.position = new Vector3(0, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > -0.2f && touchPosition.y < 0.2f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(0, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > -0.2f && touchPosition.y < 0.2f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(0, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > -0.2f && touchPosition.y < 0.2f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(0, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > -0.2f && touchPosition.y < 0.2f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(0, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                //end center move
                // middle 1 cross
                if (touchPosition.x > 1.4f && touchPosition.x < 1.6f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(0, 0, 0))
                    {
                        transform.position = new Vector3(1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > 1.4f && touchPosition.x < 1.6f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 0, 0))
                    {
                        transform.position = new Vector3(1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.4f && touchPosition.x < 1.6f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(0, 1.5f, 0))
                    {
                        transform.position = new Vector3(1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.4f && touchPosition.x < 1.6f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(3, 0, 0))
                    {
                        transform.position = new Vector3(1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.4f && touchPosition.x < 1.6f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(3, 1.5f, 0))
                    {
                        transform.position = new Vector3(1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.4f && touchPosition.x < 1.6f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(3, 3, 0))
                    {
                        transform.position = new Vector3(1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.4f && touchPosition.x < 1.6f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 3, 0))
                    {
                        transform.position = new Vector3(1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.4f && touchPosition.x < 1.6f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(0, 3, 0))
                    {
                        transform.position = new Vector3(1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                // middle up
                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(0, 0, 0))
                    {
                        transform.position = new Vector3(0, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(0, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(0, 3, 0))
                    {
                        transform.position = new Vector3(0, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.2f && touchPosition.x < 0.2f && touchPosition.y > 1.4f && touchPosition.y < 1.6f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(0, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                // middle cross 2

                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(0, 1.5f, 0))
                    {
                        transform.position = new Vector3(-1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(0, 0, 0))
                    {
                        transform.position = new Vector3(-1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(0, 3, 0))
                    {
                        transform.position = new Vector3(-1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 3, 0))
                    {
                        transform.position = new Vector3(-1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(-3, 3, 0))
                    {
                        transform.position = new Vector3(-1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(-3, 1.5f, 0))
                    {
                        transform.position = new Vector3(-1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(-3, 0, 0))
                    {
                        transform.position = new Vector3(-1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 0, 0))
                    {
                        transform.position = new Vector3(-1.5f, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(0, 0, 0))
                    {
                        transform.position = new Vector3(-1.5f, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(-1.5f, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(-3, 0, 0))
                    {
                        transform.position = new Vector3(-1.5f, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(-1.5f, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                // middle cross 3
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(0, 0, 0))
                    {
                        transform.position = new Vector3(-1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 0, 0))
                    {
                        transform.position = new Vector3(-1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-3, 0, 0))
                    {
                        transform.position = new Vector3(-1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-3, -1.5f, 0))
                    {
                        transform.position = new Vector3(-1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-3, -3, 0))
                    {
                        transform.position = new Vector3(-1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -3, 0))
                    {
                        transform.position = new Vector3(-1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(0, -3, 0))
                    {
                        transform.position = new Vector3(-1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(0, -1.5f, 0))
                    {
                        transform.position = new Vector3(-1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                // middle down
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(0, 0, 0))
                    {
                        transform.position = new Vector3(0, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(0, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(0, -3, 0))
                    {
                        transform.position = new Vector3(0, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(0, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                //middle cross 3
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(0, 0, 0))
                    {
                        transform.position = new Vector3(1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(0, -1.5f, 0))
                    {
                        transform.position = new Vector3(1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(0, -3, 0))
                    {
                        transform.position = new Vector3(1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -3, 0))
                    {
                        transform.position = new Vector3(1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(3, -3, 0))
                    {
                        transform.position = new Vector3(1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(3, -1.5f, 0))
                    {
                        transform.position = new Vector3(1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(3, 0, 0))
                    {
                        transform.position = new Vector3(1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 0, 0))
                    {
                        transform.position = new Vector3(1.5f, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(0, 0, 0))
                    {
                        transform.position = new Vector3(1.5f, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(1.5f, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(3, 0, 0))
                    {
                        transform.position = new Vector3(1.5f, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(1.5f, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                //side left
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 0, 0))
                    {
                        transform.position = new Vector3(3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(3, 1.5f, 0))
                    {
                        transform.position = new Vector3(3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(3, -1.5f, 0))
                    {
                        transform.position = new Vector3(3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                //side left up
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(3, 0, 0))
                    {
                        transform.position = new Vector3(3, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(3, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(3, 3, 0))
                    {
                        transform.position = new Vector3(3, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                //side corner 1
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(3, 1.5f, 0))
                    {
                        transform.position = new Vector3(3, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(3, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 3, 0))
                    {
                        transform.position = new Vector3(3, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                //side up left
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(1.5f, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(0, 3, 0))
                    {
                        transform.position = new Vector3(1.5f, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(3, 3, 0))
                    {
                        transform.position = new Vector3(1.5f, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                // side upper
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 3, 0))
                    {
                        transform.position = new Vector3(0, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(0, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(0, 1.5f, 0))
                    {
                        transform.position = new Vector3(0, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 3, 0))
                    {
                        transform.position = new Vector3(0, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(0, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                // side up right
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(0, 3, 0))
                    {
                        transform.position = new Vector3(-1.5f, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(-3, 3, 0))
                    {
                        transform.position = new Vector3(-1.5f, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(-1.5f, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                //side corner 2
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 3, 0))
                    {
                        transform.position = new Vector3(-3, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(-3, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                {
                    if (PlayerPosition == new Vector3(-3, 1.5f, 0))
                    {
                        transform.position = new Vector3(-3, 3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                // side corner down
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(-3, 3, 0))
                    {
                        transform.position = new Vector3(-3, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(-3, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                {
                    if (PlayerPosition == new Vector3(-3, 0, 0))
                    {
                        transform.position = new Vector3(-3, 1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                // side right
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(-3, 1.5f, 0))
                    {
                        transform.position = new Vector3(-3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 1.5f, 0))
                    {
                        transform.position = new Vector3(-3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(-3, -1.5f, 0))
                    {
                        transform.position = new Vector3(-3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, 0, 0))
                    {
                        transform.position = new Vector3(-3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(-3, 0, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                // side right down
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-3, 0, 0))
                    {
                        transform.position = new Vector3(-3, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(-3, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(-3, -3, 0))
                    {
                        transform.position = new Vector3(-3, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                // side corner 3
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(-3, -1.5f, 0))
                    {
                        transform.position = new Vector3(-3, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(-3, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -3, 0))
                    {
                        transform.position = new Vector3(-3, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                // side down right
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(-3, -3, 0))
                    {
                        transform.position = new Vector3(-1.5f, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(0, -3, 0))
                    {
                        transform.position = new Vector3(-1.5f, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(-1.5f, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                //side down
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -3, 0))
                    {
                        transform.position = new Vector3(0, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(-1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(0, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(0, -1.5f, 0))
                    {
                        transform.position = new Vector3(0, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(0, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -3, 0))
                    {
                        transform.position = new Vector3(0, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                // side down left
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(1.5f, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(0, -3, 0))
                    {
                        transform.position = new Vector3(1.5f, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(3, -3, 0))
                    {
                        transform.position = new Vector3(1.5f, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                //side corner 4
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(3, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -3, 0))
                    {
                        transform.position = new Vector3(3, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                {
                    if (PlayerPosition == new Vector3(3, -1.5f, 0))
                    {
                        transform.position = new Vector3(3, -3, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }

                // side left down
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(1.5f, -1.5f, 0))
                    {
                        transform.position = new Vector3(3, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(3, 0, 0))
                    {
                        transform.position = new Vector3(3, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }
                if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                {
                    if (PlayerPosition == new Vector3(3, -3, 0))
                    {
                        transform.position = new Vector3(3, -1.5f, 0);
                    }

                    else
                    {
                        transform.position = this.transform.position;
                    }

                }












                #region additionPractice

                //if (PlayerPosition == new Vector3(-2, 0, 0))

                //    if (touchPosition.x > 1 && touchPosition.x < 3 && touchPosition.y > -1 && touchPosition.y < 1)
                //{
                //    transform.position = new Vector3(2, 0, 0);
                //}

                //else
                //    {
                //        transform.position = new Vector3(-2, 0, 0);
                //    }



                //if (touchPosition.x > 1 && touchPosition.x < 3 && touchPosition.y > 2 && touchPosition.y < 4)
                //{
                //    transform.position = new Vector3(2, 3, 0);
                //}
                //else if (touchPosition.x > -3 && touchPosition.x < -1 && touchPosition.y > -4 && touchPosition.y < -2)
                //{
                //    transform.position = new Vector3(-2, -3, 0);
                //}
                //else if (touchPosition.x > -3 && touchPosition.x < -1 && touchPosition.y > -1 && touchPosition.y < 1)
                //{
                //    transform.position = new Vector3(-2, 0, 0);
                //}
                //else if (touchPosition.x > 1 && touchPosition.x < 3 && touchPosition.y > -4 && touchPosition.y < -2)
                //{
                //    transform.position = new Vector3(2, -3, 0);
                //}

                #endregion endPractice


            }

        }
       

    }
}
