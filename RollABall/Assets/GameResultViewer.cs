using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResultViewer : MonoBehaviour
{
    // PlayerPickupItemManagerからフラグを受けとるためにPlayerPickupItemManagerを参照する
    public PlayerPickupItemManager PlayerPickupItemManager;

    // 結果を表示するTextMeshProを参照する
    public TextMeshProUGUI ResultText;

    private void Start()
    {
        // 結果を表示するTextMeshProの文字を空にする
        ResultText.text = string.Empty;
    }

    void Update()
    {

        // PlayerPickupItemManagerのフラグが立てばGame Clearを表示する
        if (PlayerPickupItemManager.GetAllPickupItems)
        {
            ResultText.text = "Game Clear";
        }
    }
}
