using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    // SESoundManager��Unity��ŎQ�Ƃ���
    public SESoundManager SESoundManager;

    // �Փ˔�����擾���܂�
    private void OnCollisionEnter(Collision collision)
    {
        // �����Փ˂��Ă����̂�Player��������
        if(collision.gameObject.tag.Equals("Player")){

            // PickupItem�p��SE���Đ�����
            SESoundManager.PlayPickupItemSE();

            // �����������܂�
            Destroy(this.gameObject);    
        }
    }
}
