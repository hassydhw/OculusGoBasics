using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInputManager : MonoBehaviour
{

    public TextMesh buttonInputMesh;
    public TextMesh lastButtonMesh;
    public TextMesh padInfoMesh;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //トリガー、タッチパッドボタンを押し続けているかどうか
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            buttonInputMesh.text = "trigger pressing";
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            buttonInputMesh.text = "pad pressing";
        }
        else
        {
            buttonInputMesh.text = "nothing pressed";
        }



        //トリガー、タッチパッドボタン、バックボタンを押したかどうか
        if (OVRInput.GetDown(OVRInput.Button.Back))
        {
            lastButtonMesh.text = "backbutton pressed";
        }
        else if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            lastButtonMesh.text = "trigger pressed";
        }
        else if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
            lastButtonMesh.text = "pad pressed";
        }


        //タッチパッドにさわったばあいはその位置を表示、パッドの中心が0,0
        if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
        {
            //            padInfoMesh.text = "pad touching";
            Vector2 touchPadPt = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
            padInfoMesh.text = touchPadPt.ToString();
        }
        else
        {
            padInfoMesh.text = "pad NOT TOUCH";
        }




    }
}
