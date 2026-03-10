using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class handInterraction : MonoBehaviour
{
    public GameObject hand;
    public GameObject objects=null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check if the trigger is pressed
        if (SteamVR_Input.GetStateDown("GrabPinch", SteamVR_Input_Sources.Any))
        {
            objects.transform.parent = hand.transform;
            Rigidbody rb = objects.GetComponent<Rigidbody>();
            rb.isKinematic = true;
        }

        if (SteamVR_Input.GetStateUp("GrabPinch", SteamVR_Input_Sources.Any))
        {
            objects.transform.parent = hand.transform;
            Rigidbody rb = objects.GetComponent<Rigidbody>();
            rb.isKinematic = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        objects = other.gameObject;
    }

}
