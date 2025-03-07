using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMan2 : MonoBehaviour
{
    public string sceneName;
    public void ChangeScene()
    {
        StartCoroutine(WaitScene());
    }

    public IEnumerator WaitScene()
    {
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene(sceneName);
        
    }
}
