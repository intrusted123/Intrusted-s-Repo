using System.Collections;
using Valve.VR;
using UnityEngine;
using UnityEngine.XR;


[RequireComponent(typeof(Rigidbody))]
public class Interactable : MonoBehaviour
    
{   [HideInInspector]
    public Hand m_ActiveHand;
}
