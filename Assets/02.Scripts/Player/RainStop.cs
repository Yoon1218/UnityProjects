using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainStop : MonoBehaviour
{
    public GameObject rainPrefab;
    public GameObject rainObj;
    readonly string player = "Player";
    void Start()
    {
        rainObj = Instantiate(rainPrefab); // 비 프리팹을 인스턴스화하여 Rainobj에 저장
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(player))
            Destroy(rainObj);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(player))
            rainObj = Instantiate (rainPrefab);
    }
}
