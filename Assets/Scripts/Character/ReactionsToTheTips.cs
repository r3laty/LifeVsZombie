using UnityEngine;
using TMPro;

public class ReactionsToTheTips : MonoBehaviour
{
    [HideInInspector] public bool isTrigger;
    public TextMeshProUGUI tipForBuildingText;
    public TextMeshProUGUI tipForChopText;
    public TextMeshProUGUI cantForChopText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TheStartOfHouse"))
        {
            isTrigger = true;
            tipForBuildingText.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TheStartOfHouse"))
        {
            isTrigger = false;
            tipForBuildingText.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NormalTree"))
        {
            tipForChopText.gameObject.SetActive(true);
        }
        if(collision.gameObject.CompareTag("BigTree"))
        {
            cantForChopText.gameObject.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("NormalTree"))
        {
            tipForChopText.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("BigTree"))
        {
            cantForChopText.gameObject.SetActive(false);
        }
    }
}
