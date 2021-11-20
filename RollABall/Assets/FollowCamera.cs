using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Follow‚·‚éTarget
    public GameObject followTarget;

    // Target‚Æ‚È‚éˆÊ’u‚Æ‚Ì·
    public Vector3 OffSet;

    private void LateUpdate()
    {
        // ©•ª‚ÌˆÊ’u‚ÉFollow‚·‚éTarget‚Æ‚ÌˆÊ’u‚Æ‚Ì·‚ğposition‚É‘ã“ü‚·‚é
        transform.position = followTarget.transform.position + OffSet;
        // ©•ª‚ÌŒü‚«‚ğFollow‚·‚éTarget‚ÉŒü‚©‚¹‚é
        transform.LookAt(followTarget.transform);
    }
}
