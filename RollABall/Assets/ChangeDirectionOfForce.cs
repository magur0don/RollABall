using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirectionOfForce : MonoBehaviour
{
    public float JumpPower = 500f;

    private void OnCollisionEnter(Collision collision)
    {
        // Playerが当たったら
        if (collision.gameObject.tag.Equals("Player"))
        {
            // PlayerのRigidbodyに対してy軸に対して500kgの力を加える

            // 何をやってるか超ざっくり計算すると下記になります
            // Playerの加速度は 500(力の大きさ)/1(質量)*0.02f(Unityの固定長のフレーム更新時間)で10
            // 10 (加速度) * 0.02f(Unityの固定長のフレーム更新時間) =  0.2
            // 0.2 + ( 9.8(重力加速度)* 0.5f * 0.02(Unityの固定長のフレーム更新時間)の2の累乗)
            // y軸に対して位置を 0.2 + 0.00196 =0.20196f を毎フレームY軸に足していく
            
            // なんで落ちるかというと、上記計算と同時に逆向きの力がかかり続けているのでいつか落ちてくる
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,JumpPower,0));
        }
    }
}
