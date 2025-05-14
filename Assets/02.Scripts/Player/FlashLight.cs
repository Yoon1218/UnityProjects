using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
//FŰ�� ������ ����Ʈ�� ������ �ٽ� FŰ�� ������ ������
// ���� ����: audio Source, clip
public class FlashLight : MonoBehaviour
{
    [SerializeField] Light flashlight;
    [SerializeField] AudioSource AudioSource;
    public AudioClip AudioClip;
    void Start()
    {
        flashlight = GetComponent<Light>();
        AudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;
            AudioSource.PlayOneShot(AudioClip,1f);
        }
    }
}
