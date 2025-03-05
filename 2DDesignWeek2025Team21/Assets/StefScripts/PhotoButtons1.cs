using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Unity.VisualScripting;
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
    Canvas Canvas1;
    Canvas Canvas2;
    Canvas Canvas3;
    Canvas Canvas4;
    Canvas Canvas5;
    Canvas Canvas6;
    Canvas Canvas7;
    Canvas Canvas8;


    string path = null;

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
        Canvas1 = photo1.transform.parent.gameObject.GetComponent<Canvas>();
        Canvas2 = photo2.transform.parent.gameObject.GetComponent<Canvas>();
        Canvas3 = photo3.transform.parent.gameObject.GetComponent<Canvas>();
        Canvas4 = photo4.transform.parent.gameObject.GetComponent<Canvas>();
        Canvas5 = photo5.transform.parent.gameObject.GetComponent<Canvas>();
        Canvas6 = photo6.transform.parent.gameObject.GetComponent<Canvas>();
        Canvas7 = photo7.transform.parent.gameObject.GetComponent<Canvas>();
        Canvas8 = photo8.transform.parent.gameObject.GetComponent<Canvas>();
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
        //GameObject parentGameObject = photo1.transform.parent.gameObject;
        
        Canvas1.sortingOrder = 1;

        //path = Application.streamingAssetsPath + "/FreddyFazzbear1.jpg";
        path = Application.streamingAssetsPath + "/Puzzle1PDFTest.pdf";
        PrintFiles();
        //var image = Resources.Load(filename) as TextAsset;
        //File.WriteAllBytes(Application.persistentDataPath + "/" + filename + ".png", image.bytes);
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



    public void photo1Print()
    {
        path = Application.streamingAssetsPath + "/FreddyFazzbear1.jpg";
        PrintFiles();
        
    }


    public void GenerateFile()
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        using (var fileStream = new FileStream(path,FileMode.OpenOrCreate, FileAccess.Write))
        {
            //var document = new Document(PageSize.A4)
            //var writer = PDFWriter
        } 


    }

    void PrintFiles()
    {

        UnityEngine.Debug.Log(path);
        if (path == null)
            return;

        if (File.Exists(path))
        {
            UnityEngine.Debug.Log("file found");
            //var startInfo = new System.Diagnostics.ProcessStartInfo(path);
            //int i = 0;
            //foreach (string verb in startInfo.Verbs)
            //{
            //    // Display the possible verbs.
            //    Debug.Log(string.Format("  {0}. {1}", i.ToString(), verb));
            //    i++;
            //}
        }
        else
        {
            UnityEngine.Debug.Log("file not found");
            return;
        }
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
        process.StartInfo.UseShellExecute = true;
        process.StartInfo.FileName = path;
        //process.StartInfo.Verb = "print";

        process.Start();
        //process.WaitForExit();

        //up is for opening a pdf and bottom is for printing a jpg

        /*ProcessStartInfo info = new ProcessStartInfo(path);
        info.Verb = "print";
        info.CreateNoWindow = true;
        info.WindowStyle = ProcessWindowStyle.Hidden;

        Process p = new Process();
        p.StartInfo = info;
        //p.StartInfo.ErrorDialog = true;
        p.Start();
        p.WaitForExit();*/

    }


}
