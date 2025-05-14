using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class SkeletonCTRL : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Transform Skeltr;
    [SerializeField] NavMeshAgent Navi;
    public float tracedist = 20.0f;
    public float attackdist = 1.5f;
    public Transform playertr;
    readonly int hashAttack = Animator.StringToHash("Attack");
    readonly int hashtrace = Animator.StringToHash("Move");
                                //�����Ҵ�� ���� ���ڿ��� �о ������ ��ȯ
    void Start()
    {
        animator = GetComponent<Animator>();
        Skeltr = GetComponent<Transform>();
        playertr = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        float dist = Vector3.Distance(Skeltr.position, playertr.position);

        if (dist <= tracedist)
        {
            Navi.SetDestination(playertr.position);
            Navi.isStopped = false;
            animator.SetBool(hashtrace,true);
            animator.SetBool(hashAttack, false);
            if (dist <= attackdist)
            {
                Navi.isStopped = true;
                animator.SetBool(hashAttack, true);
            }
        }
        else
        {
            animator.SetBool(hashtrace, false);
            animator.SetBool(hashAttack, false);
            Navi.isStopped = true;
        }
    }
}
