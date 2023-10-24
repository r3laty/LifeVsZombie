using UnityEngine;

public class DayAndNightCycle : MonoBehaviour
{
    [SerializeField] private float dayDuration = 30;
    [SerializeField] private Light sun;

    private float _timeOfDay = 1;

    private void Update()
    {
        _timeOfDay += Time.deltaTime / dayDuration;
        if (_timeOfDay > 1)
            _timeOfDay -= 1;

        sun.transform.localRotation = Quaternion.Euler(_timeOfDay * 360, 180, 0);
        if (_timeOfDay > 0.5f && _timeOfDay < 1)
        {
            Debug.Log("Night");
        }
    }
}
