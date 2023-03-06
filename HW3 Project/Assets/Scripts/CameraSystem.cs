using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void Update()
    {
        Vector3 moveDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) moveDir.z = +0.1f;
        if (Input.GetKey(KeyCode.A)) moveDir.x = -0.1f;
        if (Input.GetKey(KeyCode.S)) moveDir.z = -0.1f;
        if (Input.GetKey(KeyCode.D)) moveDir.x = +0.1f;

        float moveSpeed = 50f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
}
