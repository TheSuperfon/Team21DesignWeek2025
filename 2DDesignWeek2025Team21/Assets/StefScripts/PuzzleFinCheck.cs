using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFinCheck : MonoBehaviour
{
    public GameObject tile1;
    public GameObject tile2;
    public GameObject tile3;
    public GameObject tile4;
    public GameObject tile5;
    public GameObject tile6;
    public GameObject ghostHand;
    public GameObject spookyText1;
    public GameObject spookyText2;
    public GameObject spookyText3;
    public GameObject spookyText4;
    public GameObject spookyText5;
    public GameObject spookyText6;
    // Start is called before the first frame update
    void Start()
    {
        tile1.SetActive(false);
        tile2.SetActive(false);
        tile3.SetActive(false);
        tile4.SetActive(false);
        tile5.SetActive(false);
        tile6.SetActive(false);
        ghostHand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((spookyText1.activeInHierarchy == true))
        {
            tile1.SetActive(true);
        }
        if ((spookyText2.activeInHierarchy == true))
        {
            tile2.SetActive(true);
        }
        if ((spookyText3.activeInHierarchy == true))
        {
            tile3.SetActive(true);
        }
        if ((spookyText4.activeInHierarchy == true))
        {
            tile4.SetActive(true);
        }
        if ((spookyText5.activeInHierarchy == true))
        {
            tile5.SetActive(true);
        }
        if ((spookyText6.activeInHierarchy == true))
        {
            tile6.SetActive(true);
        }
    }

    public void endgame()
    {
        if ((tile1.activeInHierarchy == true) && (tile2.activeInHierarchy == true) && (tile3.activeInHierarchy == true) && (tile4.activeInHierarchy == true))
        {
            ghostHand.SetActive (true); 
        }

    }
}
