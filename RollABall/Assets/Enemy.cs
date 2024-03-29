using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // 追いかけるPlayerの位置
    public Transform TargetPlayer;

    // 結果を表示するGameResultViewer
    public GameResultViewer GameResultViewer;

    // UnityのAI機能
    private NavMeshAgent navMeshAgent;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // 移動先の決定
        navMeshAgent.SetDestination(TargetPlayer.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameResultViewer.ResultText.text = "Game Over";
        }
    }
}
