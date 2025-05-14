using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
//F키를 누르면 라이트가 켜지고 다시 F키를 누르면 꺼진다
// 사운드 구현: audio Source, clip
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
