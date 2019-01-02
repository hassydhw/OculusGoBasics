using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DpadInputManager : MonoBehaviour
{

    public TextMesh dpadInputMesh;
    public TextMesh padInfoMesh;

    Vector2 touchPadPt;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            Vector2 touchPadPt = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

            if (touchPadPt.x > 0.5 && -0.5 < touchPadPt.y && touchPadPt.y < 0.5)
            {
                //右方向
                dpadInputMesh.text = "right";
            }
            if (touchPadPt.x < -0.5 && -0.5 < touchPadPt.y && touchPadPt.y < 0.5)
            {
                //左方向
                dpadInputMesh.text = "left";
            }
            if (touchPadPt.y > 0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5)
            {
                //上方向
                dpadInputMesh.text = "up";
            }
            if (touchPadPt.y < -0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5)
            {
                //下方向
                dpadInputMesh.text = "down";
            }

            padInfoMesh.text = touchPadPt.ToString();

        }
        else
        {
            dpadInputMesh.text = "nothing pressed";
            padInfoMesh.text = "";
        }


    }
}
