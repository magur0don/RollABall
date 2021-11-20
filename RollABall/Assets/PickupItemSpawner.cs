using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemSpawner : MonoBehaviour
{
    // ¶¬‚·‚éPickupItem
    public GameObject PickupItem;
    // ¶¬‚·‚éŒÂ”
    public int SpawnCount = 0;
    // ¶¬‚·‚é‰~‚Ì”¼Œa
    //public float SpawnCircleRadius = 3f;

    public List<Transform> SpawnPositions = new List<Transform>();

    // PickupItem‚É“n‚·SESoundManager
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

        // ‰~ü‚ğSpawnCount‚ÅŠ„‚Á‚½Šp“x
        //float radian = Mathf.PI * 2 / SpawnCount;
        //for (int i = 0; i < SpawnCount; i++)
        //{
        //    GameObject Pick = Instantiate(PickupItem);
        //    // V‚µ‚­Vector3‚ğì¬‚µA¶¬‚µ‚½PickupItem‚ÌPosition‚ğ‘ã“ü
        //    Vector3 pos = Pick.transform.position;
        //    // Pos‚Ìz‚Ì’l‚É‰~ü‚Ìy‚Ì’l‚ğSpawnCircleRadius‚ÅŠ|‚¯‚½’l‚ğ‘ã“ü
        //    pos.z = Mathf.Sin(radian * (i + 1)) * SpawnCircleRadius;
        //    // Pos‚Ìx‚Ì’l‚É‰~ü‚Ìx‚Ì’l‚ğSpawnCircleRadius‚ÅŠ|‚¯‚½’l‚ğ‘ã“ü
        //    pos.x = Mathf.Cos(radian * (i + 1)) * SpawnCircleRadius;
        //    // ‹‚ß‚ç‚ê‚½Vector3‚ğ¶¬‚³‚ê‚½Pick‚Ìposition‚É‘ã“ü
        //    Pick.transform.position = pos;
        //}


    }
}
