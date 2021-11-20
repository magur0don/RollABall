using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemSpawner : MonoBehaviour
{
    // ��������PickupItem
    public GameObject PickupItem;
    // ���������
    public int SpawnCount = 0;
    // ��������~�̔��a
    //public float SpawnCircleRadius = 3f;

    public List<Transform> SpawnPositions = new List<Transform>();

    // PickupItem�ɓn��SESoundManager
    public SESoundManager SESoundManager;

    void Start()
    {

        for (int i = 0; i < SpawnPositions.Count; i++)
        {
            GameObject Pick = Instantiate(PickupItem);
            
            Pick.GetComponent<PickupItem>().SESoundManager = SESoundManager;

            Pick.transform.position = SpawnPositions[i].position;
            SpawnCount++;
        }

        // �~����SpawnCount�Ŋ������p�x
        //float radian = Mathf.PI * 2 / SpawnCount;
        //for (int i = 0; i < SpawnCount; i++)
        //{
        //    GameObject Pick = Instantiate(PickupItem);
        //    // �V����Vector3���쐬���A��������PickupItem��Position����
        //    Vector3 pos = Pick.transform.position;
        //    // Pos��z�̒l�ɉ~����y�̒l��SpawnCircleRadius�Ŋ|�����l����
        //    pos.z = Mathf.Sin(radian * (i + 1)) * SpawnCircleRadius;
        //    // Pos��x�̒l�ɉ~����x�̒l��SpawnCircleRadius�Ŋ|�����l����
        //    pos.x = Mathf.Cos(radian * (i + 1)) * SpawnCircleRadius;
        //    // ���߂�ꂽVector3�𐶐����ꂽPick��position�ɑ��
        //    Pick.transform.position = pos;
        //}


    }
}
