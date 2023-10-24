using UnityEngine;

public class ReactionsToTheTips : MonoBehaviour
{
    [HideInInspector] public bool isTrigger;
    public GameObject tipForBuildingText;
    public GameObject tipForChopText;
    public GameObject cantForChopText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TheStartOfHouse"))
        {
            isTrigger = true;
            tipForBuildingText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TheStartOfHouse"))
        {
            isTrigger = false;
            tipForBuildingText.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NormalTree"))
        {
            tipForChopText.SetActive(true);
        }
        if(collision.gameObject.CompareTag("BigTree"))
        {
            cantForChopText.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("NormalTree"))
        {
            tipForChopText.SetActive(false);
        }
        if (collision.gameObject.CompareTag("BigTree"))
        {
            cantForChopText.SetActive(false);
        }
    }
}
