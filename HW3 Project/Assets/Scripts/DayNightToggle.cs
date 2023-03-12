using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightToggle : MonoBehaviour
{
    public Material skyDomeMaterial;
    float night = 0.5f;
    float day = 0.0f;

    public void ToggleDayNight()
    {
        Vector2 offset = skyDomeMaterial.GetTextureOffset("_MainTex");
        if (offset.x == day)
        {
            skyDomeMaterial.SetTextureOffset("_MainTex", new Vector2(night, 0));
        }
        else if (offset.x == night)
        {
            skyDomeMaterial.SetTextureOffset("_MainTex", new Vector2(day, 0));
        }
        else
        {
            skyDomeMaterial.SetTextureOffset("_MainTex", new Vector2(day, 0));
        }
    }
}
