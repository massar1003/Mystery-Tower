using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp1 : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 posR;

    //�����ǂ⏰�ɐG��ăv���C���[���u�Ԉړ�
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
        other.gameObject.transform.localEulerAngles = new Vector3(posR.x, posR.y, posR.z);
    }
}
