using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    public int currentTilesSolved = 0;
    [SerializeField] int tilesToSolve = 12;
    bool isPuzzleSolved = false;
    public GameObject SpookyText;
    public Slot NeedRemove1;
    public Slot NeedRemove2;
    public Slot NeedRemove3;
    public Slot NeedRemove4;
    public PhotoButtons1 PhotoScript;
    public string PathNavigate;
    public bool ActivateMetaTile;


    // Start is called before the first frame update
    void Start()
    {
        SpookyText.SetActive(false);
        ActivateMetaTile = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isPuzzleSolved);
        if(currentTilesSolved == tilesToSolve && !isPuzzleSolved)
        {
            if ((NeedRemove1  != null) && (NeedRemove2 != null) && (NeedRemove3 != null)  && (NeedRemove4  != null))
            {
                if ((NeedRemove1.isOccupied == false) && (NeedRemove2.isOccupied == false) && (NeedRemove3.isOccupied == false) && (NeedRemove4.isOccupied == false))
                {
                    CompletePuzzle();
                    PhotoScript.path = Application.streamingAssetsPath + PathNavigate;
                    PhotoScript.PrintFiles();
                }


            }
            else
            {
                CompletePuzzle();
                PhotoScript.path = Application.streamingAssetsPath + PathNavigate;
                PhotoScript.PrintFiles();
            }
            
        }
    }

    public void AddTile()
    {
        Debug.Log("added tile!");
        currentTilesSolved += 1;
    }

    public void SubtractTile()
    {
        Debug.Log("subtracted tile!");
        currentTilesSolved -= 1;
    }

    void CompletePuzzle()
    {
        Debug.Log("puzzle complete!");
        isPuzzleSolved = true;
        SpookyText.SetActive(true);
        ActivateMetaTile = true;
    }
}
