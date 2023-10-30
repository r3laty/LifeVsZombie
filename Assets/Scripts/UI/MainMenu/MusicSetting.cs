using UnityEngine;
using UnityEngine.UI;

public class MusicSetting : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private AudioSource mainMusic;

    private void Update() => mainMusic.volume = musicSlider.value;
}
