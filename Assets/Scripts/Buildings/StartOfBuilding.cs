    using UnityEngine;

public class StartOfBuilding : MonoBehaviour
{
    [SerializeField] private ReactionsToTheTips tipsReaction;
    [SerializeField] private GameObject prefab;

    [HideInInspector] public bool isBuilded = false;
    private void Update()
    {
        if (tipsReaction.isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            GameObject builded = Instantiate(prefab);
            builded.transform.position = new Vector3(32f, -1.5f, 15f);
            tipsReaction.isTrigger = false;
            tipsReaction.tipForBuildingText.text = "Нажмите \"Е\" чтобы продолжить строительство";
            isBuilded = true;
        }
    }
}
