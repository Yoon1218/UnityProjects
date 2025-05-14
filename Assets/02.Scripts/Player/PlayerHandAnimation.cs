using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//왼쪽 쉬프트 키와 w키를 동시에 눌렀을 때 총을 접는 애니메이션을 재생하는 스크립트 구현
//왼쪽 쉬프트 키와 w키 둘중에 하나라도 떼면 애니메이션이 멈추고 총을 겨누는 애니메이션이 재생되도록 구현
public class PlayerHandAnimation : MonoBehaviour
{
    public Animation anim;
    readonly string running = "running";
    readonly string runstop = "runStop";
    readonly string fire = "fire";
    public bool isrunning = false;




    void Start()
    {           //자기자신의 자식 오브젝트를 찾고 그 자식 오브젝트의 자식 오브젝트를 찾는다
        anim = transform.GetChild(0).GetChild(0).GetComponent<Animation>();
     
    }

    void Update()
    {
        SprintAnimation();
        FireAnimation();

    }

    public void FireAnimation()
    {
        if (Input.GetMouseButton(0) && !isrunning)
        {
            anim.Play(fire);
        }
    }

    private void SprintAnimation()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            anim.Play(running);
            isrunning = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.W))
        {
            anim.Play(runstop);
            isrunning = false;
        }
    }
}
