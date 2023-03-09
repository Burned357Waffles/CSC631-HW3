using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ToggleText : MonoBehaviour
{
    public int transitionTime = 1;

    void Start()
    {
        gameObject.SetActive(true);
    }

    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }    
    }
}
