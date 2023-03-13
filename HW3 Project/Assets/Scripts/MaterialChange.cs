using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material Material1;
    public Material Material2;
    public GameObject body;
    private bool whichState = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

    }
    // Update is called once per frame

    public void ChangeMaterial()
    {
        if (whichState)
        {
            body.GetComponent<MeshRenderer>().material = Material2;
            whichState = !whichState;
        }
        else
        {
            body.GetComponent<MeshRenderer>().material = Material1;
            whichState = !whichState;
        }
    }


}
