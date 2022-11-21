using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestNavAI : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;

    void Start()
    {
        // �ش� ��ü�� NavMeshAgent �� �����մϴ�.
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // �������Ӹ��� ��ǥ�������� �̵��մϴ�.
        agent.SetDestination(target.position);

    }
}