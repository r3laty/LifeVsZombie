using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ChoppingTrees : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI amountOfWoodText;
    [SerializeField] private float choppingDistance = 2;
    [SerializeField] private GameObject tipForChop;

    [HideInInspector] public int woodAmount = 0;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, choppingDistance))
            {
                IColectable tree = hit.collider.GetComponentInParent<IColectable>();
                if (tree != null)
                {
                    tree.Chop();
                    tipForChop.SetActive(false);
                    

                    if(tree is NormalTree)
                    {
                        woodAmount++;
                    }
                }
                else
                {
                    Debug.Log("Not this IColectable");
                }
            }
            UpdateText(woodAmount);
        }
    }
    public void UpdateText(int woodAmount)
    {
        amountOfWoodText.text = woodAmount.ToString() + " дерева";
    }
}
