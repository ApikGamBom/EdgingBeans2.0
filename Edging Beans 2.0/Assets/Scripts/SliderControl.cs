using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    [Header("All")]
    [SerializeField] private float lowestValue = 0.001f;



    [Header("Mouse Sensitivity")]
    [SerializeField] private TMP_InputField MouseSensInputField;
    [SerializeField] private Slider MouseSensSlider;
    [SerializeField] private float MouseSensMaxValue = 5f;
    [SerializeField] private float initialMouseSens = 1f;

    [Header("Resume Delay")]
    [SerializeField] private TMP_InputField ResumeDelayInputField;
    [SerializeField] private Slider ResumeDelaySlider;
    [SerializeField] private float ResumeDelayMaxValue = 10f;
    [SerializeField] private float initialResumeDelay = 2f;
    
    [Header("Music Volume")]
    [SerializeField] private TMP_InputField MusicVolumeInputField;
    [SerializeField] private Slider MusicVolumeSlider;
    [SerializeField] private float MusicVolumeMaxValue = 100f;
    [SerializeField] private float initialMusicVolume = 100f;

    [Header("Gameplay Volume")]
    [SerializeField] private TMP_InputField GameplayVolumeInputField;
    [SerializeField] private Slider GameplayVolumeSlider;
    [SerializeField] private float GameplayVolumeMaxValue = 100f;
    [SerializeField] private float initialGameplayVolume = 100f;
    void Start()
    {
        MouseSensSlider.value = initialMouseSens / MouseSensMaxValue;
        UpdateMouseSense(MouseSensSlider.value);

        ResumeDelaySlider.value = initialResumeDelay / ResumeDelayMaxValue;
        UpdateResumeDelay(ResumeDelaySlider.value);
        
        MusicVolumeSlider.value = initialMusicVolume / MusicVolumeMaxValue;
        UpdateMusicVolume(MusicVolumeSlider.value);

        GameplayVolumeSlider.value = initialGameplayVolume / GameplayVolumeMaxValue;
        UpdateGameplayVolume(GameplayVolumeSlider.value);

        MouseSensInputField.onEndEdit.AddListener(delegate { ValidateAndSetMouseSens(MouseSensInputField.text); });
        MouseSensSlider.onValueChanged.AddListener(delegate(float value) { UpdateMouseSense(value); });
        UpdateMouseSense(MouseSensSlider.value);

        ResumeDelayInputField.onEndEdit.AddListener(delegate { ValidateAndSetResumeDelay(ResumeDelayInputField.text); });
        ResumeDelaySlider.onValueChanged.AddListener(delegate(float value) { UpdateResumeDelay(value); });
        UpdateResumeDelay(ResumeDelaySlider.value);
        
        MusicVolumeInputField.onEndEdit.AddListener(delegate { ValidateAndSetMusicVolume(MusicVolumeInputField.text); });
        MusicVolumeSlider.onValueChanged.AddListener(delegate(float value) { UpdateMusicVolume(value); });
        UpdateMusicVolume(MusicVolumeSlider.value);

        GameplayVolumeInputField.onEndEdit.AddListener(delegate { ValidateAndSetGameplayVolume(ResumeDelayInputField.text); });
        GameplayVolumeSlider.onValueChanged.AddListener(delegate(float value) { UpdateGameplayVolume(value); });
        UpdateGameplayVolume(GameplayVolumeSlider.value);
    }

    public void UpdateMouseSense(float value)
    {
        float scaledValue = value * MouseSensMaxValue;
        MouseSensInputField.text = scaledValue.ToString("0.0");
    }
    private void ValidateAndSetMouseSens(string input)
    {

        if (float.TryParse(input, out float value))
        {
            if (value >= lowestValue && value <= MouseSensMaxValue)
            {
            MouseSensSlider.value = value / MouseSensMaxValue;
            }
            else
            {
                Debug.Log("Input out of range");
                MouseSensInputField.text = (MouseSensSlider.value * MouseSensMaxValue).ToString("0.0");
            }
        }
        else
        {
            Debug.Log("Invalid input");
            MouseSensInputField.text = (MouseSensSlider.value * MouseSensMaxValue).ToString("0.0");
        }
    }



    public void UpdateResumeDelay(float value)
    {
        float scaledValue = value * ResumeDelayMaxValue;
        ResumeDelayInputField.text = scaledValue.ToString("0.0");
    }
    private void ValidateAndSetResumeDelay(string input)
    {

        if (float.TryParse(input, out float value))
        {
            if (value >= lowestValue && value <= ResumeDelayMaxValue)
            {
            ResumeDelaySlider.value = value / ResumeDelayMaxValue;
            }
            else
            {
                Debug.Log("Input out of range");
                ResumeDelayInputField.text = (ResumeDelaySlider.value * ResumeDelayMaxValue).ToString("0.0");
            }
        }
        else
        {
            Debug.Log("Invalid input");
            ResumeDelayInputField.text = (ResumeDelaySlider.value * ResumeDelayMaxValue).ToString("0.0");
        }
    }

    public void UpdateMusicVolume(float value)
    {
        float scaledValue = value * MusicVolumeMaxValue;
        MusicVolumeInputField.text = scaledValue.ToString("0.0");
    }
    private void ValidateAndSetMusicVolume(string input)
    {

        if (float.TryParse(input, out float value))
        {
            if (value >= lowestValue && value <= MusicVolumeMaxValue)
            {
            MusicVolumeSlider.value = value / MusicVolumeMaxValue;
            }
            else
            {
                Debug.Log("Input out of range");
                MusicVolumeInputField.text = (MusicVolumeSlider.value * MusicVolumeMaxValue).ToString("0.0");
            }
        }
        else
        {
            Debug.Log("Invalid input");
            MusicVolumeInputField.text = (MusicVolumeSlider.value * MusicVolumeMaxValue).ToString("0.0");
        }
    }



    public void UpdateGameplayVolume(float value)
    {
        float scaledValue = value * GameplayVolumeMaxValue;
        GameplayVolumeInputField.text = scaledValue.ToString("0.0");
    }
    private void ValidateAndSetGameplayVolume(string input)
    {

        if (float.TryParse(input, out float value))
        {
            if (value >= lowestValue && value <= GameplayVolumeMaxValue)
            {
            GameplayVolumeSlider.value = value / GameplayVolumeMaxValue;
            }
            else
            {
                Debug.Log("Input out of range");
                GameplayVolumeInputField.text = (GameplayVolumeSlider.value * GameplayVolumeMaxValue).ToString("0.0");
            }
        }
        else
        {
            Debug.Log("Invalid input");
            GameplayVolumeInputField.text = (GameplayVolumeSlider.value * GameplayVolumeMaxValue).ToString("0.0");
        }
    }
}
 