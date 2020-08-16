using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class GrabScript : MonoBehaviour
{
    
    public SteamVR_Action_Boolean grabAction;
    private Rigidbody connectedBody;
    public SteamVR_Input_Sources inputSource;
    private BoxCollider isTriggerCollider;
    private FixedJoint fixedJoint;
    
    
    


    void Start()
    {
        isTriggerCollider = gameObject.GetComponent<BoxCollider>();
        
    }
       
    void Update()
    {
        
        if (grabAction.stateUp)
        {           
            Destroy(fixedJoint);
            connectedBody = null;
          

        }
        if (!fixedJoint)
        {
            if (SteamVR_Input.GetState("GrabGrip", inputSource))
            {
                fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = connectedBody;
                
            }
        }

    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Interactable")
        {
            connectedBody = collider.attachedRigidbody;
        }
        
        
        
    }

}
