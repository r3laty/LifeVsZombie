using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChoppingTrees : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI amountOfWoodText;
    [SerializeField] private float choppingDistance = 2;

    [HideInInspector] public int normalWoodAward = 0;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, choppingDistance))
            {
                ICollectable tree = hit.collider.GetComponentInParent<ICollectable>();
                if (tree != null)
                {
                    amountOfWoodText.text = tree.LootFromChopping().ToString() + " дерева";
                }
            }
        }
    }
}
