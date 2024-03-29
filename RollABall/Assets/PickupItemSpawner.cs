using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemSpawner : MonoBehaviour
{
    // 生成するPickupItem
    public GameObject PickupItem;
    // 生成する個数
    public int SpawnCount = 0;
    // 生成する円の半径
    //public float SpawnCircleRadius = 3f;

    public List<Transform> SpawnPositions = new List<Transform>();

    // PickupItemに渡すSESoundManager
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

        // 円周をSpawnCountで割った角度
        //float radian = Mathf.PI * 2 / SpawnCount;
        //for (int i = 0; i < SpawnCount; i++)
        //{
        //    GameObject Pick = Instantiate(PickupItem);
        //    // 新しくVector3を作成し、生成したPickupItemのPositionを代入
        //    Vector3 pos = Pick.transform.position;
        //    // Posのzの値に円周のyの値をSpawnCircleRadiusで掛けた値を代入
        //    pos.z = Mathf.Sin(radian * (i + 1)) * SpawnCircleRadius;
        //    // Posのxの値に円周のxの値をSpawnCircleRadiusで掛けた値を代入
        //    pos.x = Mathf.Cos(radian * (i + 1)) * SpawnCircleRadius;
        //    // 求められたVector3を生成されたPickのpositionに代入
        //    Pick.transform.position = pos;
        //}


    }
}
