using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReactionsToTheTips : MonoBehaviour
{

    [HideInInspector] public bool isTrigger;
    public GameObject _tipsText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TheStartOfHouse"))
        {
            isTrigger = true;
            _tipsText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TheStartOfHouse"))
        {
            isTrigger = false;
            _tipsText.SetActive(false);
        }
    }
}
