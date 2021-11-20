using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    // SESoundManager‚ğUnityã‚ÅQÆ‚·‚é
    public SESoundManager SESoundManager;

    // Õ“Ë”»’è‚ğæ“¾‚µ‚Ü‚·
    private void OnCollisionEnter(Collision collision)
    {
        // ‚à‚µÕ“Ë‚µ‚Ä‚«‚½‚Ì‚ªPlayer‚¾‚Á‚½‚ç
        if(collision.gameObject.tag.Equals("Player")){

            // PickupItem—p‚ÌSE‚ğÄ¶‚·‚é
            SESoundManager.PlayPickupItemSE();

            // ©•ª‚ğÁ‚µ‚Ü‚·
            Destroy(this.gameObject);    
        }
    }
}
