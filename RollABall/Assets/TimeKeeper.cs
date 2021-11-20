using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeKeeper : MonoBehaviour
{
    // ���Ԃ�\������e�L�X�g
    public TextMeshProUGUI TimeText;

    // GameResult��\������N���X
    public GameResultViewer GameResultViewer;

    // ��������
    public float TimeLimit = 20f;

    // GameState���Q�Ƃ���
    public GameState GameState;

    private void Update()
    {
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }

        // �������Ԃ�0����ŁA���A�܂��S�Ă�PickupItem���擾������Ă��Ȃ�������
        if (TimeLimit > 0 && !GameResultViewer.PlayerPickupItemManager.GetAllPickupItems)
        {
            // TimeLimit�𖈃t���[���A�t���[���ƃt���[���̍����ň����Ă���
            TimeLimit -= Time.deltaTime;

            TimeText.text = $"{(int)TimeLimit + 1}";
        }
        // �S�Ă�PickupItem���擾�����ꂽ��A�J�E���g���~�߂�
        else if (GameResultViewer.PlayerPickupItemManager.GetAllPickupItems)
        {
            TimeText.text = $"{(int)TimeLimit + 1}";
        }
        // �������Ԃ�0��聫�ɂȂ�����Q�[���I�[�o�[
        else
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            TimeText.text = $"{0}";
            GameResultViewer.ResultText.text = "Game Over";
        }
    }
}
