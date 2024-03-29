using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    // SESoundManagerをUnity上で参照する
    public SESoundManager SESoundManager;

    // 衝突判定を取得します
    private void OnCollisionEnter(Collision collision)
    {
        // もし衝突してきたのがPlayerだったら
        if(collision.gameObject.tag.Equals("Player")){

            // PickupItem用のSEを再生する
            SESoundManager.PlayPickupItemSE();

            // 自分を消します
            Destroy(this.gameObject);    
        }
    }
}
