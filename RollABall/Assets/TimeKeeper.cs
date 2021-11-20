using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeKeeper : MonoBehaviour
{
    // 時間を表示するテキスト
    public TextMeshProUGUI TimeText;

    // GameResultを表示するクラス
    public GameResultViewer GameResultViewer;

    // 制限時間
    public float TimeLimit = 20f;

    // GameStateを参照する
    public GameState GameState;

    private void Update()
    {
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }

        // 制限時間が0より上で、かつ、まだ全てのPickupItemが取得しきれていなかったら
        if (TimeLimit > 0 && !GameResultViewer.PlayerPickupItemManager.GetAllPickupItems)
        {
            // TimeLimitを毎フレーム、フレームとフレームの差分で引いていく
            TimeLimit -= Time.deltaTime;

            TimeText.text = $"{(int)TimeLimit + 1}";
        }
        // 全てのPickupItemが取得しきれたら、カウントを止める
        else if (GameResultViewer.PlayerPickupItemManager.GetAllPickupItems)
        {
            TimeText.text = $"{(int)TimeLimit + 1}";
        }
        // 制限時間が0より↓になったらゲームオーバー
        else
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            TimeText.text = $"{0}";
            GameResultViewer.ResultText.text = "Game Over";
        }
    }
}
