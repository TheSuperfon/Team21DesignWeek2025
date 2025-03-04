using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoButtons1 : MonoBehaviour
{
    public GameObject photo1;
    public GameObject photo2;
    public GameObject photo3;
    public GameObject photo4;
    public GameObject photo5;
    public GameObject photo6;
    public GameObject photo7;
    public GameObject photo8;
    public Transform location1;
    public Transform location2;
    // Start is called before the first frame update
    void Start()
    {
        photo1.SetActive(false);
        photo2.SetActive(false);
        photo3.SetActive(false);
        photo4.SetActive(false);
        photo5.SetActive(false);
        photo6.SetActive(false);
        photo7.SetActive(false);
        photo8.SetActive(false);
        //location1 = ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void photo1Button()
    {
        if (photo1.activeInHierarchy == true)
        {
            photo1.SetActive(false);
        }
        else
        {
            photo1.SetActive(true);
        }
        
    }
    public void photo2Button()
    {
        if (photo2.activeInHierarchy == true)
        {
            photo2.SetActive(false);
        }
        else
        {
            photo2.SetActive(true);
        }

    }
    public void photo3Button()
    {
        if (photo3.activeInHierarchy == true)
        {
            photo3.SetActive(false);
        }
        else
        {
            photo3.SetActive(true);
        }

    }
    public void photo4Button()
    {
        if (photo4.activeInHierarchy == true)
        {
            photo4.SetActive(false);
        }
        else
        {
            photo4.SetActive(true);
        }

    }
    public void photo5Button()
    {
        if (photo5.activeInHierarchy == true)
        {
            photo5.SetActive(false);
        }
        else
        {
            photo5.SetActive(true);
        }

    }
    public void photo6Button()
    {
        if (photo6.activeInHierarchy == true)
        {
            photo6.SetActive(false);
        }
        else
        {
            photo6.SetActive(true);
        }

    }
    public void photo7Button()
    {
        if (photo7.activeInHierarchy == true)
        {
            photo7.SetActive(false);
        }
        else
        {
            photo7.SetActive(true);
        }

    }
    public void photo8Button()
    {
        if (photo8.activeInHierarchy == true)
        {
            photo8.SetActive(false);
        }
        else
        {
            photo8.SetActive(true);
        }

    }


}
