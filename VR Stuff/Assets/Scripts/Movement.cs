using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Action_Vector2 Input;
    public float speed = 2;
    public Transform vrCamera;
    Quaternion headYaw;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thumbstickPos = headYaw * new Vector3(Input.axis.x, 0, Input.axis.y);
        transform.position += speed * thumbstickPos * Time.deltaTime;
         headYaw = Quaternion.Euler(0, vrCamera.transform.eulerAngles.y, 0);
    }
}
