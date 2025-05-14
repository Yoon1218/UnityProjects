using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�ݶ��̴��� �ε����� �� ����Ʈ�� �������� ����
//�ݶ��̴� �ۿ� ������ ����Ʈ�� �������� ����
public class LightOnOff : MonoBehaviour
{
    public Light _light;
    AudioSource source;
    public AudioClip _lightOnSound;
    public AudioClip _lightOffSound;
    float Timeprev;
    readonly string player = "Player";
    void Start()
    {
        _light = GetComponent<Light>();
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) //istrigger üũ �ǰ� �ݶ��̴��ȿ� ������ ��
    {
        if (other.gameObject.CompareTag(player))
        {
            _light.enabled = true;
            source.PlayOneShot(_lightOnSound, 1f);
        }
    }

    private void OnTriggerExit(Collider other) // istrigger�� üũ �ǰ� �ݶ��̴��� ���� ������ ��
    {
        if (other.gameObject.CompareTag(player))
        {
            _light.enabled = false;
            source.PlayOneShot(_lightOffSound, 1f);
        }
    }
}
