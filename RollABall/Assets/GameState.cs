using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // �Q�[���i�s�x
    public enum GameProgressStates
    {
        GameStart = 0,
        GameMain,
        GameResult
    }

    // �O����Q�Ƃ��邽�߂�GameProgressStates�̕ϐ�
    public GameProgressStates GameProgressState = GameProgressStates.GameStart;

    // Game�̐i�s�x��ύX���郁�\�b�h
    public void SetGameProgressState(GameProgressStates gameProgressState)
    {
        GameProgressState = gameProgressState;
     
    }
}
