using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // FollowするTarget
    public GameObject followTarget;

    // Targetとなる位置との差
    public Vector3 OffSet;

    private void LateUpdate()
    {
        // 自分の位置にFollowするTargetとの位置との差をpositionに代入する
        transform.position = followTarget.transform.position + OffSet;
        // 自分の向きをFollowするTargetに向かせる
        transform.LookAt(followTarget.transform);
    }
}
