using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DpadMove : MonoBehaviour
{
    public TextMesh dpadInputMesh;
    //    public TextMesh padInfoMesh;

    Vector2 touchPadPt;
    public GameObject targetPlayerObj;
    public float forwardSpeed;
    public float rotationSpeed;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            dpadInputMesh.text = "trigger";
            //前進
            targetPlayerObj.transform.position += (targetPlayerObj.transform.rotation * Vector3.forward).normalized * forwardSpeed * Time.deltaTime;
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            Vector2 touchPadPt = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
            if (touchPadPt.y > 0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5)
            {
                //上方向
                dpadInputMesh.text = "up";
                //前進
                targetPlayerObj.transform.position += (targetPlayerObj.transform.rotation * Vector3.forward).normalized * forwardSpeed * Time.deltaTime;

            }
            if (touchPadPt.x > 0.5 && -0.5 < touchPadPt.y && touchPadPt.y < 0.5)
            {
                //右方向
                dpadInputMesh.text = "right";
                //右回りに回転
                targetPlayerObj.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            }
            if (touchPadPt.x < -0.5 && -0.5 < touchPadPt.y && touchPadPt.y < 0.5)
            {
                //左方向
                dpadInputMesh.text = "left";
                //左回りに回転
                targetPlayerObj.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            }
            //if (touchPadPt.y < -0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5)
            //{
            //    //下方向
            //    dpadInputMesh.text = "down";
            //    //今回は移動には使わない、後退するという実装もありかも
            //}


        }


    }
}
