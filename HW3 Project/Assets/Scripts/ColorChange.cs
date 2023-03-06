using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material Material1;
    public Material Material2;
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        Object.GetComponent<MeshRenderer>().material = Material1;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Object.GetComponent<MeshRenderer>().material = Material2;
        }
        if (Input.GetKey(KeyCode.G))
        {
            Object.GetComponent<MeshRenderer>().material = Material1;
        }
    }
    // Update is called once per frame

}
