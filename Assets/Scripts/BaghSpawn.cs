using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaghSpawn : MonoBehaviour
{
    public static BaghSpawn _instance;

    public BaghSpawn Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Instance doesnot exists");
            }
            return _instance;

        }
    }


    public GameObject[] players;
    public int count;
    public int Total = 0;
    private Vector3 playerPos;
    // MachiHolder and BoardManager
    private GameObject machiHolder;
    public BoardManager BM;


    // public GameObject prefab;


    public void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        machiHolder = GameObject.Find("MachiHolder");
        machiHolder.SetActive(false);
        BM = GetComponent<BoardManager>();
        BM.enabled = false;

        BagSpawn();

    }

    // Update is called once per frame
    void Update()
    {

        bagMoveMent();

    }


    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bagh")&& other.gameObject.CompareTag("Machi"))
        {
            this.gameObject.transform.position = playerPos;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bagh")&& other.gameObject.CompareTag("Machi"))
        {
            this.gameObject.transform.position = playerPos;
        }
    }

    public void BagSpawn()
    {
        for (int i = 0; i < players.Length; i++)
        {

            players[i].SetActive(false);
        }
    }

    public void bagMoveMent()
    {
        if (Input.touchCount > 0)
        {
            playerPos = transform.position;
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);


            if (Total < 4)
            {
                if (touch.phase == TouchPhase.Stationary)
                {

                    // quater 1
                    // center .
                    if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                    {
                        if (players[0].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }

                        players[0].SetActive(true);
                        players[0].transform.position = new Vector3(0, 0, 0);
                        BagTouchActivate tochscript = GetComponent<BagTouchActivate>();
                        players[0].GetComponent<BagTouchActivate>().enabled = false;
                        BagMindScript mind = GetComponent<BagMindScript>();
                        players[0].GetComponent<BagMindScript>().enabled = false;

                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;


                    }

                    if (touchPosition.x > 1.25f && touchPosition.x < 1.75 && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                    {
                        if (players[1].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[1].SetActive(true);
                        players[1].transform.position = new Vector3(1.5f, 0, 0);
                        players[1].GetComponent<BagTouchActivate>().enabled = false;
                        players[1].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;

                    }
                    // left--
                    else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -0.1f && touchPosition.y < 0.1f)
                    {
                        if (players[2].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[2].SetActive(true);
                        players[2].transform.position = new Vector3(3, 0, 0);
                        players[2].GetComponent<BagTouchActivate>().enabled = false;
                        players[2].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;

                    }
                    // up-
                    if (touchPosition.x > -0.1f && touchPosition.x < 0.1f && touchPosition.y > 1.25 && touchPosition.y < 1.75)
                    {
                        if (players[3].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[3].SetActive(true);
                        players[3].transform.position = new Vector3(0, 1.5f, 0);
                        players[3].GetComponent<BagTouchActivate>().enabled = false;
                        players[3].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    //up--
                    if (touchPosition.x > -0.1f && touchPosition.x < 0.1f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                    {
                        if (players[4].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[4].SetActive(true);
                        players[4].transform.position = new Vector3(0, 3, 0);
                        players[4].GetComponent<BagTouchActivate>().enabled = false;
                        players[4].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    else if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > 1.25 && touchPosition.y < 1.75)
                    {
                        if (players[5].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[5].SetActive(true);
                        players[5].transform.position = new Vector3(1.5f, 1.5f, 0);
                        players[5].GetComponent<BagTouchActivate>().enabled = false;
                        players[5].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }

                    else if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                    {
                        if (players[6].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[6].SetActive(true);
                        players[6].transform.position = new Vector3(1.5f, 3, 0);
                        players[6].GetComponent<BagTouchActivate>().enabled = false;
                        players[6].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 2.75 && touchPosition.y < 3.25)
                    {
                        if (players[7].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[7].SetActive(true);
                        players[7].transform.position = new Vector3(3, 3, 0);
                        players[7].GetComponent<BagTouchActivate>().enabled = false;
                        players[7].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }

                    else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                    {
                        if (players[8].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[8].SetActive(true);
                        players[8].transform.position = new Vector3(3, 1.5f, 0);
                        players[8].GetComponent<BagTouchActivate>().enabled = false;
                        players[8].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // quater 2
                    //down-
                    else if (touchPosition.x > -0.1f && touchPosition.x < 0.1f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                    {
                        if (players[9].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[9].SetActive(true);
                        players[9].transform.position = new Vector3(0, -1.5f, 0);
                        players[9].GetComponent<BagTouchActivate>().enabled = false;
                        players[9].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // down--
                    else if (touchPosition.x > -0.1f && touchPosition.x < 0.1f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                    {
                        if (players[10].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[10].SetActive(true);
                        players[10].transform.position = new Vector3(0, -3, 0);
                        players[10].GetComponent<BagTouchActivate>().enabled = false;
                        players[10].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // down left cross-
                    else if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75 && touchPosition.y < -1.25)
                    {
                        if (players[11].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[11].SetActive(true);
                        players[11].transform.position = new Vector3(1.5f, -1.5f, 0);
                        players[11].GetComponent<BagTouchActivate>().enabled = false;
                        players[11].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;

                    }
                    //down left
                    else if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                    {
                        if (players[12].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[12].SetActive(true);
                        players[12].transform.position = new Vector3(1.5f, -3, 0);
                        players[12].GetComponent<BagTouchActivate>().enabled = false;
                        players[12].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // down left corner
                    else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                    {
                        if (players[13].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[13].SetActive(true);
                        players[13].transform.position = new Vector3(3, -3, 0);
                        players[13].GetComponent<BagTouchActivate>().enabled = false;
                        players[13].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // down p left
                    else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                    {
                        if (players[14].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[14].SetActive(true);
                        players[14].transform.position = new Vector3(3, -1.5f, 0);
                        players[14].GetComponent<BagTouchActivate>().enabled = false;
                        players[14].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // quater 3
                    //right-
                    else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -0.1f && touchPosition.y < 0.1f)
                    {
                        if (players[15].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[15].SetActive(true);
                        players[15].transform.position = new Vector3(-1.5f, 0, 0);
                        players[15].GetComponent<BagTouchActivate>().enabled = false;
                        players[15].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }

                    // right--
                    else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -0.1f && touchPosition.y < 0.1f)
                    {
                        if (players[16].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[16].SetActive(true);
                        players[16].transform.position = new Vector3(-3, 0, 0);
                        players[16].GetComponent<BagTouchActivate>().enabled = false;
                        players[16].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // down right cross
                    else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                    {
                        if (players[17].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[17].SetActive(true);
                        players[17].transform.position = new Vector3(-1.5f, -1.5f, 0);
                        players[17].GetComponent<BagTouchActivate>().enabled = false;
                        players[17].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }

                    //down right-
                    else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                    {
                        if (players[18].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[18].SetActive(true);
                        players[18].transform.position = new Vector3(-1.5f, -3, 0);
                        players[18].GetComponent<BagTouchActivate>().enabled = false;
                        players[18].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }

                    // rightdown
                    else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
                    {
                        if (players[19].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[19].SetActive(true);
                        players[19].transform.position = new Vector3(-3, -1.5f, 0);
                        players[19].GetComponent<BagTouchActivate>().enabled = false;
                        players[19].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // down right cross
                    else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
                    {
                        if (players[20].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[20].SetActive(true);
                        players[20].transform.position = new Vector3(-3, -3, 0);
                        players[20].GetComponent<BagTouchActivate>().enabled = false;
                        players[20].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // quater 4
                    // up righ cross
                    else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                    {
                        if (players[21].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[21].SetActive(true);
                        players[21].transform.position = new Vector3(-1.5f, 1.5f, 0);
                        players[21].GetComponent<BagTouchActivate>().enabled = false;
                        players[21].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }

                    //up right-
                    else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                    {
                        if (players[22].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[22].SetActive(true);
                        players[22].transform.position = new Vector3(-1.5f, 3, 0);
                        players[22].GetComponent<BagTouchActivate>().enabled = false;
                        players[22].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }

                    // up p right
                    else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
                    {
                        if (players[23].activeSelf == false && Input.touchCount == 1)
                        {

                            count = 1;
                            Total = Total + count;
                        }
                        players[23].SetActive(true);
                        players[23].transform.position = new Vector3(-3, 1.5f, 0);
                        players[23].GetComponent<BagTouchActivate>().enabled = false;
                        players[23].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                    // up right corner
                    else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
                    {
                        if (players[24].activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        players[24].SetActive(true);
                        players[24].transform.position = new Vector3(-3, 3, 0);
                        players[24].GetComponent<BagTouchActivate>().enabled = false;
                        players[24].GetComponent<BagMindScript>().enabled = false;
                        BM.enabled = true;
                        BoardManager._instance.BS.enabled = false;
                    }
                }

            }

            else if (Total > 4)
            {
                gameObject.GetComponent<BaghSpawn>().enabled = false;
                gameObject.GetComponent<BagTouchActivate>().enabled = true;
                gameObject.GetComponent<BagMindScript>().enabled = true;
            }




        }
    }

}
