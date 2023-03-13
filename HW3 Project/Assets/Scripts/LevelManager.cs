using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private string sceneName1 = "SampleScene";
    private string sceneName2 = "Scene3";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    public void SceneChange()
    {
        if (SceneManager.GetActiveScene().name == sceneName1)
        {
            SceneManager.LoadScene(sceneName2);
        }
        else if (SceneManager.GetActiveScene().name == sceneName2)
        {
            SceneManager.LoadScene(sceneName1);
        }
    }

}
