using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ContinueOfBuilding : MonoBehaviour
{
    [SerializeField] private GameObject layer2Prefab;
    [SerializeField] private GameObject layer3Prefab;
    [SerializeField] private GameObject layer4Prefab;
    [SerializeField] private GameObject roofPrefab;
    [Space]
    [SerializeField] private GameObject theEndOfDemoText;
    [Space]
    [SerializeField] private CheckResourses resourses;
    [SerializeField] private ReactionsToTheTips reactionsToTheTips;
    
    private bool _isAllowToContinue;
    private bool _isAllowToContinue2;
    private bool _isReady;
    private void Update()
    {
        SecondLayer();
        StartCoroutine(ThirdLayer());
        StartCoroutine(FourthLayer());
        StartCoroutine(FinalLayer());
    }
    private void SecondLayer()
    {
        if (resourses.isReadyToContinue)
        {
            GameObject secondLayerWalls = Instantiate(layer2Prefab);
            secondLayerWalls.transform.position = new Vector3(32, -0.54f, 15);
            _isAllowToContinue = true;
            resourses.isReadyToContinue = false;
            Debug.Log("2nd layer");
        }
    }
    private IEnumerator ThirdLayer()
    {
        if (_isAllowToContinue && reactionsToTheTips.isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            GameObject thirdLayerWalls = Instantiate(layer3Prefab);
            thirdLayerWalls.transform.position = new Vector3(32, 0.31f, 15);
            _isAllowToContinue = false;
            yield return new WaitForSeconds(1);
            _isAllowToContinue2 = true;
            Debug.Log("3nd layer");
        }
    }
    private IEnumerator FourthLayer()
    {
        if (_isAllowToContinue2 && reactionsToTheTips.isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            GameObject fourthLayerWalls = Instantiate(layer4Prefab);
            fourthLayerWalls.transform.position = new Vector3(32, 2.209f, 15);
            _isAllowToContinue2 = false;
            yield return new WaitForSeconds(1);
            _isReady = true;
            Debug.Log("4nd layer");
        }
    }
    private IEnumerator FinalLayer()
    {
        if (_isReady && reactionsToTheTips.isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            GameObject roof = Instantiate(roofPrefab);
            roof.transform.position = new Vector3(49.61919f, -5.051299f, 24.81f);
            _isAllowToContinue2 = false;
            yield return new WaitForSeconds(0.5f);
            _isReady = true;
            TheEndOfDemo();
            Debug.Log("Final layer");
        }
    }
    private void TheEndOfDemo()
    {
        Time.timeScale = 0;
        theEndOfDemoText.SetActive(true);
    }
}
