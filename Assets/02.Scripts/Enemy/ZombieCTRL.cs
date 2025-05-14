using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//�÷��̾ ���� ���� �ȿ� ������ �����ϰ�
//���� �����ȿ� ������ �����ϴ� ��ũ��Ʈ
//�������� ���ݹ����� ���Ϸ��� �Ÿ��� ���ؾ��Ѵ�. �÷��̾�� ������ ��ġ�� �˾ƾ���
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent (typeof(Animator))]
public class ZombieCTRL : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Transform zomBieTr;
    [SerializeField] NavMeshAgent navi;
    public float traceDist = 20.0f; //��������
    public float attackDist = 3.0f; // ���ݹ���\
    public Transform playertr;
    readonly int hashAttack = Animator.StringToHash("IsAttack");
    readonly int hashtrace = Animator.StringToHash("IsTrace");
    void Start()
    {
        playertr = GameObject.FindWithTag("Player").transform;
                    //���̶�Ű���� Player��� �±׸� ���� ������Ʈ�� Ʈ�������� ������
    }

    void Update()
    {
        float dist = Vector3.Distance(zomBieTr.position,playertr.position);

        if (dist <= traceDist)
        {
            navi.SetDestination(playertr.position);
            navi.isStopped = false;
            animator.SetBool(hashtrace, true);
            animator.SetBool(hashAttack, false);
            if (dist <= attackDist)
            {
                navi.isStopped = true;
                animator.SetBool(hashAttack, true);
            }
        }
        else
        {
            animator.SetBool(hashtrace, false);
            animator.SetBool(hashAttack, false);
            navi.isStopped = true;
        }

    }
}
