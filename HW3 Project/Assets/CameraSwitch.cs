using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1")){
            PlayerCam();
        }

        if(Input.GetKeyDown("2")){
            WorldCam();
        }
    }
    
    void PlayerCam()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }
    void WorldCam()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }

}
