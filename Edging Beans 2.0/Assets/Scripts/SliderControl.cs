using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderControl : MonoBehaviour
{
    public TextMeshProUGUI  MouseSens;
    public TextMeshProUGUI  ResumeDelay;
    // Start is called before the first frame update
    public void updateMouseSense(float value)
    {
        float mouseSenseLocalValue = value;
        MouseSens.text = mouseSenseLocalValue.ToString("0.0");
    }
}
