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
        //���̊K�w�̃I�u�W�F�N�g�i�v���C���[�j��transform�𓾂�B
        PlayerTransform = transform.parent;
        //���g��transform�𓾂�B
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