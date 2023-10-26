using UnityEngine;
using TMPro;
using System.Collections;

public class NotEnoughtResourses : MonoBehaviour
{
    [SerializeField] private StartOfBuilding startingBuilding;
    [SerializeField] private ReactionsToTheTips tipsReaction;
    [SerializeField] private TextMeshProUGUI exeption;
    [SerializeField] private ChoppingTrees choppingTrees;

    private void Update()
    {
        if (startingBuilding.isBuilded)
        {
            startingBuilding.enabled = false;
            StartCoroutine(ShowExeption());
        }
    }
    private IEnumerator ShowExeption()
    {
        if (choppingTrees.woodAmount < 3 && tipsReaction.isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            tipsReaction.tipForBuildingText.gameObject.SetActive(false);
            exeption.gameObject.SetActive(true);
            yield return new WaitForSeconds(2);
            exeption.gameObject.SetActive(false);
        }
        else if(choppingTrees.woodAmount >= 3 && tipsReaction.isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Building continue...");
            choppingTrees.woodAmount -= 3;
            choppingTrees.UpdateText(choppingTrees.woodAmount);
        }
    }
}
