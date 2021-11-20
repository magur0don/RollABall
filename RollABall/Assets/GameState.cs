using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // ゲーム進行度
    public enum GameProgressStates
    {
        GameStart = 0,
        GameMain,
        GameResult
    }

    // 外から参照するためのGameProgressStatesの変数
    public GameProgressStates GameProgressState = GameProgressStates.GameStart;

    // Gameの進行度を変更するメソッド
    public void SetGameProgressState(GameProgressStates gameProgressState)
    {
        GameProgressState = gameProgressState;
     
    }
}
