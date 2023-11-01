using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNightCycle : MonoBehaviour
{
    [SerializeField] private float dayDuration = 30;
    [SerializeField] private Light sun;
    [Header("Zombies")]
    [SerializeField] private GameObject zombiePrefab;
    [SerializeField] private Transform zombieSpawnPoint;
    [SerializeField] private float zombieSpawnDelay = 2.5f;

    private List<GameObject> _zombies = new List<GameObject>();
    private bool _isNight;
    private float _timeOfDay = 1;
    private void Start()
    {
        StartCoroutine(SpawnZombies());
    }
    private void Update()
    {
        _timeOfDay += Time.deltaTime / dayDuration;
        if (_timeOfDay > 1)
            _timeOfDay -= 1;

        sun.transform.localRotation = Quaternion.Euler(_timeOfDay * 360, 180, 0);
        if (_timeOfDay > 0.5f && _timeOfDay < 1)
        {
            _isNight = true;
            Debug.Log("Night");
        }
        else
        {
            _isNight = false;
        }
        if(!_isNight)
        {
            DamageZombies();
        }
    }
    private IEnumerator SpawnZombies()
    {
        while(true)
        {
            if (_isNight)
            {
                yield return new WaitForSeconds(zombieSpawnDelay);
                GameObject zombie = Instantiate(zombiePrefab, zombieSpawnPoint.position, Quaternion.identity);
                _zombies.Add(zombie);
            }
            yield return null;
        }
    }
    private void DamageZombies()
    {
        for (int i = 0; i < _zombies.Count; i++)
        {
            Destroy(_zombies[i]);
        }
        _zombies.Clear();
    }
}
