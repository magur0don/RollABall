using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Follow����Target
    public GameObject followTarget;

    // Target�ƂȂ�ʒu�Ƃ̍�
    public Vector3 OffSet;

    private void LateUpdate()
    {
        // �����̈ʒu��Follow����Target�Ƃ̈ʒu�Ƃ̍���position�ɑ������
        transform.position = followTarget.transform.position + OffSet;
        // �����̌�����Follow����Target�Ɍ�������
        transform.LookAt(followTarget.transform);
    }
}
