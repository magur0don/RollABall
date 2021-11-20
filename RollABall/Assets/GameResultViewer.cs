using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResultViewer : MonoBehaviour
{
    // PlayerPickupItemManager����t���O���󂯂Ƃ邽�߂�PlayerPickupItemManager���Q�Ƃ���
    public PlayerPickupItemManager PlayerPickupItemManager;

    // ���ʂ�\������TextMeshPro���Q�Ƃ���
    public TextMeshProUGUI ResultText;

    private void Start()
    {
        // ���ʂ�\������TextMeshPro�̕�������ɂ���
        ResultText.text = string.Empty;
    }

    void Update()
    {

        // PlayerPickupItemManager�̃t���O�����Ă�Game Clear��\������
        if (PlayerPickupItemManager.GetAllPickupItems)
        {
            ResultText.text = "Game Clear";
        }
    }
}
