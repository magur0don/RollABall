using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirectionOfForce : MonoBehaviour
{
    public float JumpPower = 500f;

    private void OnCollisionEnter(Collision collision)
    {
        // Player������������
        if (collision.gameObject.tag.Equals("Player"))
        {
            // Player��Rigidbody�ɑ΂���y���ɑ΂���500kg�̗͂�������

            // ��������Ă邩����������v�Z����Ɖ��L�ɂȂ�܂�
            // Player�̉����x�� 500(�͂̑傫��)/1(����)*0.02f(Unity�̌Œ蒷�̃t���[���X�V����)��10
            // 10 (�����x) * 0.02f(Unity�̌Œ蒷�̃t���[���X�V����) =  0.2
            // 0.2 + ( 9.8(�d�͉����x)* 0.5f * 0.02(Unity�̌Œ蒷�̃t���[���X�V����)��2�̗ݏ�)
            // y���ɑ΂��Ĉʒu�� 0.2 + 0.00196 =0.20196f �𖈃t���[��Y���ɑ����Ă���
            
            // �Ȃ�ŗ����邩�Ƃ����ƁA��L�v�Z�Ɠ����ɋt�����̗͂������葱���Ă���̂ł��������Ă���
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,JumpPower,0));
        }
    }
}
