using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    int currentTilesSolved = 1;
    [SerializeField] int tilesToSolve = 12;
    bool isPuzzleSolved = false;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
