using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vrCamera;
    public GameObject cameraRig;
    private Quaternion headYaw;
    private Vector3 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraRig.transform.position = vrCamera.transform.position * Time.deltaTime;
        direction = headYaw * new Vector3(vrCamera.transform.position.x, 0, vrCamera.transform.eulerAngles.y);
        headYaw = Quaternion.Euler(vrCamera.transform.eulerAngles.x, 0, vrCamera.transform.eulerAngles.y);
    }

}

