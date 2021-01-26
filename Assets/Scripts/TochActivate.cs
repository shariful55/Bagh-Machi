using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TochActivate : MonoBehaviour
{

    public MindScript mind;


    void OnMouseDown()
    {

        mind.ChangePlayer(this.gameObject);
        if (BoardManager._instance.Total == 20)
        {
            GetComponent<MoveByTouch>().enabled = true;
        }
        

    }
    //void OnMouseUp()
    //{

       
    //    GetComponent<MoveByTouch>().enabled = false;

    //}

    // Update is called once per frame
    //void Update()
    //{



    //    if (Input.touchCount > 0)
    //    {
    //        Touch touch = Input.GetTouch(0);

    //        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
    //        touchPosition.z = 0f;


    //        if (touch.phase == TouchPhase.Began)
    //        {
    //            if (touchPosition==this.transform.position)
    //            {

    //                other.GetComponent<MoveByTouch>().enabled = false;
    //                GetComponent<MoveByTouch>().enabled = true;




    //            }



    //        }

    //    }
    #region pr
    //void Activate()
    //{
    //    y.enabled = true;
    //    v.enabled = true;
    //    this.gameObject.SetActive(true);

    //    //this.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    //    //MoveByTouch MoveActive = new MoveByTouch
    //    //{
    //    //    enabled = true
    //    //};
    //}

    //void DeActivate()
    //{

    //    // y.enabled = false;
    //    v.enabled = false;
    //    this.gameObject.SetActive(false);
    //    //this.enabled = false;

    //    //this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    //    //MoveByTouch MoveActive = new MoveByTouch
    //    //{
    //    //    enabled = false
    //    //};

    //}
    #endregion endpc
}

