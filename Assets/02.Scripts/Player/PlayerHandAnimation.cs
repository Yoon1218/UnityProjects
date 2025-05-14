using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� ����Ʈ Ű�� wŰ�� ���ÿ� ������ �� ���� ���� �ִϸ��̼��� ����ϴ� ��ũ��Ʈ ����
//���� ����Ʈ Ű�� wŰ ���߿� �ϳ��� ���� �ִϸ��̼��� ���߰� ���� �ܴ��� �ִϸ��̼��� ����ǵ��� ����
public class PlayerHandAnimation : MonoBehaviour
{
    public Animation anim;
    readonly string running = "running";
    readonly string runstop = "runStop";
    readonly string fire = "fire";
    public bool isrunning = false;




    void Start()
    {           //�ڱ��ڽ��� �ڽ� ������Ʈ�� ã�� �� �ڽ� ������Ʈ�� �ڽ� ������Ʈ�� ã�´�
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
