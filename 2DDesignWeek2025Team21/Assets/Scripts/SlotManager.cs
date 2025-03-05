using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    int currentTilesSolved = 1;
    [SerializeField] int tilesToSolve = 12;
    bool isPuzzleSolved = false;
    public GameObject SpookyText;

    // Start is called before the first frame update
    void Start()
    {
        SpookyText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTilesSolved > tilesToSolve && !isPuzzleSolved)
        {
            CompletePuzzle();
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
    }
}
