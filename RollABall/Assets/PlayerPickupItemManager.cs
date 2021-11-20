using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupItemManager : MonoBehaviour
{
    // PickupItem�����܂�鐔���擾���邽�߂�PickupItemSpawner���Q�Ƃ���
    public PickupItemSpawner PickupItemSpawner;

    // �v���C���[���擾�����A�C�e����
    public int PickupItemCount = 0;

    // ���܂ꂽ��
    public int PickupItemSpawnCount = 0;

    // �S�Ď擾�ŗ������̃t���O
    public bool GetAllPickupItems = false;

    // GameState���Q�Ƃ���
    public GameState GameState;

    private void Start()
    {
        // PickupItemSpawnCount��PickupItem�����܂�鐔��������
        PickupItemSpawnCount = PickupItemSpawner.SpawnCount;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }

        // �����������肪PickupItem��������
        if (collision.gameObject.tag.Equals("PickupItem"))
        {
            // PickupItemCount�̒l��1���₷
            PickupItemCount++;
            // ���܂ꂽ����PickupItemCount�����l�ɂȂ�����GetAllPickupItems�̃t���O�𗧂Ă�
            if (PickupItemCount == PickupItemSpawnCount)
            {
                GetAllPickupItems = true;
                GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            }
        }
    }
}