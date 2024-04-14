using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(AudioSource))]
public class Button : MonoBehaviour, IPointerClickHandler
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();    
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _audioSource.Play();
    }
}
