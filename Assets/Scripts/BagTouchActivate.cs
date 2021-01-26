using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagTouchActivate : MonoBehaviour
{
    public BagMindScript mind;


    void OnMouseDown()
    {

        mind.ChangePlayer(this.gameObject);
        if (BaghSpawn._instance.Total == 4)
        {
            GetComponent<MoveByTouch>().enabled = true;
        }


    }
}
