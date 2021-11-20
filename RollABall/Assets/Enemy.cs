using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // �ǂ�������Player�̈ʒu
    public Transform TargetPlayer;

    // ���ʂ�\������GameResultViewer
    public GameResultViewer GameResultViewer;

    // Unity��AI�@�\
    private NavMeshAgent navMeshAgent;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // �ړ���̌���
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
