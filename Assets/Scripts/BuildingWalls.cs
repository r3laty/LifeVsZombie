using UnityEngine;

public class BuildingWalls : MonoBehaviour
{
    [SerializeField] private ReactionsToTheTips tipsReaction;
    [SerializeField] private GameObject prefab;
    private void Update()
    {
        if (tipsReaction.isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            GameObject builded = Instantiate(prefab);
            builded.transform.position = new Vector3(32f, -1.5f, 15f);
            tipsReaction.isTrigger = false;
            Destroy(tipsReaction.tipForBuildingText);
        }
    }
}
