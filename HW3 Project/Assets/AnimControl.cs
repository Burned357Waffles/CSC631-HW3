using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class AnimControl : MonoBehaviour
{
    public GameObject theNPC;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            theNPC.GetComponent<Animator>().Play("Jump");
        }
    }
}
