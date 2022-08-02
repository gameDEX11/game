using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class setStamina : MonoBehaviour
{
    public Slider slider;
    public void setMaxstamina(int stamina)
    {
        slider.maxValue=stamina;
        slider.value=stamina;
    }
    public void SetStamina(float cStamina)
    {
        slider.value=cStamina;

    }
}
