using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.XR;


public class DpadRecenter : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            OVRManager.display.RecenterPose();
            //            InputTracking.Recenter();// これでもOK、ただしusing必要
        }
    }
}