using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    [Header("Mouse Sensitivity")]
    [SerializeField] private TMP_InputField MouseSensInputField;
    [SerializeField] private Slider MouseSensSlider;
    [SerializeField] private float MouseSensMaxValue = 5;

    [Header("Resume Delay")]
    [SerializeField] private TMP_InputField ResumeDelayInputField;
    [SerializeField] private Slider ResumeDelaySlider;
    [SerializeField] private float ResumeDelayMaxValue = 10;
    void Start()
    {
        MouseSensInputField.onEndEdit.AddListener(delegate { ValidateAndSetMouseSens(MouseSensInputField.text); });
        MouseSensSlider.onValueChanged.AddListener(delegate(float value) { UpdateMouseSense(value); });

        ResumeDelayInputField.onEndEdit.AddListener(delegate { ValidateAndSetResumeDelay(ResumeDelayInputField.text); });
        ResumeDelaySlider.onValueChanged.AddListener(delegate(float value) { UpdateResumeDelay(value); });
        
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
            if (value >= 0 && value <= MouseSensMaxValue)
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
            if (value >= 0 && value <= ResumeDelayMaxValue)
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
}
 