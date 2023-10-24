using UnityEngine;

public class NormalTree : MonoBehaviour, ICollectable
{
    [SerializeField] private ReactionsToTheTips tipsReaction;
    [SerializeField] private ChoppingTrees choppingTrees;
    public int LootFromChopping()
    {
        tipsReaction.tipForChopText.gameObject.SetActive(false);
        Destroy(gameObject);
        choppingTrees.normalWoodAward += 1;
        return choppingTrees.normalWoodAward;
    }
}
