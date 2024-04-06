using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public float speed;
    private Transform PlayerTransform;
    private Transform CameraTransform;

    void Start()
    {
        //一つ上の階層のオブジェクト（プレイヤー）のtransformを得る。
        PlayerTransform = transform.parent;
        //自身のtransformを得る。
        CameraTransform = GetComponent<Transform>();

    }

    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        PlayerTransform.transform.Rotate(0, X_Rotation * 2, 0);
        CameraTransform.transform.Rotate(-Y_Rotation * 2, 0, 0);
    }
}