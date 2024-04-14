using UnityEngine;
using UnityEngine.Audio;

public class ControlPanel : MonoBehaviour
{
    [SerializeField] AudioMixerGroup _mixer;

    private bool _isEnabled = true;
    private float _minVolume = -80f;
    private float _maxVolume = 0;

    public void ChangeMainVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("VolumeMaster", Mathf.Lerp(_minVolume, _maxVolume, volume));
    }

    public void ChangeButtonVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("VolumeEffects", Mathf.Lerp(_minVolume, _maxVolume, volume));
    }

    public void ChangeBackgroundVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("VolumeMusic", Mathf.Lerp(_minVolume, _maxVolume, volume));
    }

    public void ToggleSound()
    {
        if (_isEnabled == false)
        {
            _mixer.audioMixer.SetFloat("VolumeMaster", _maxVolume);
            _isEnabled = true;

        }
        else
        {
            _mixer.audioMixer.SetFloat("VolumeMaster", _minVolume);
            _isEnabled = false;
        }
    }
}
