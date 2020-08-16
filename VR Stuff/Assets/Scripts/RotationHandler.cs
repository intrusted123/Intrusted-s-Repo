using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cameraRig;
    public GameObject vrCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vrCamera.transform.position = cameraRig.transform.position;

    }
}
