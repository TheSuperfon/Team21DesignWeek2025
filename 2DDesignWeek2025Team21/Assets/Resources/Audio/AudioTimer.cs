using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTimer : MonoBehaviour
{
    GameObject selfObj;
    // Start is called before the first frame update
    void Start()
    {
        selfObj = GetComponent<GameObject>();
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(4f);
        selfObj.SetActive(false);

    }



}
