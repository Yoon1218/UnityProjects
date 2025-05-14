using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//플레이어가 추적 범위 안에 들어오면 추적하고
//공격 범위안에 들어오면 공격하는 스크립트
//추적범위 공격범위를 구하려면 거리를 구해야한다. 플레이어랑 좀비의 위치를 알아야함
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent (typeof(Animator))]
public class ZombieCTRL : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Transform zomBieTr;
    [SerializeField] NavMeshAgent navi;
    public float traceDist = 20.0f; //추적범위
    public float attackDist = 3.0f; // 공격범위\
    public Transform playertr;
    readonly int hashAttack = Animator.StringToHash("IsAttack");
    readonly int hashtrace = Animator.StringToHash("IsTrace");
    void Start()
    {
        playertr = GameObject.FindWithTag("Player").transform;
                    //하이라키에서 Player라는 태그를 가진 오브젝트의 트랜스폼을 가져옴
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
