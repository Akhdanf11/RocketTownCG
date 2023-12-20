using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    //store light source
    [SerializeField] private Light sun;

    //store the time  of day
    [SerializeField, Range(0, 100)] private float timeOfDay;

    //variable store speed rotation
    [SerializeField] private float sunRotationSpeed;


    //variable to store lighting presets
    [Header("LightningPreset")]
    [SerializeField] private Gradient skyColor;
    [SerializeField] private Gradient equatorColor;
    [SerializeField] private Gradient sunColor;

    private void Update()
    {
        timeOfDay += Time.deltaTime * sunRotationSpeed;
        if (timeOfDay > 100)
            timeOfDay = 0;
        UpdateSunRotation();
        UpdateLightning();
    }

    private void OnValidate()
    {
        UpdateSunRotation();
        UpdateLightning();
    }

    //function update sun rotation
    private void UpdateSunRotation()
    {
        float sunRotation = Mathf.Lerp(-90, 270, timeOfDay / 100);
        sun.transform.rotation = Quaternion.Euler(sunRotation, sun.transform.rotation.y, sun.transform.rotation.z);
    }

    //function update the light
    private void UpdateLightning()
    {
        float timeFraction = timeOfDay / 100;
        RenderSettings.ambientEquatorColor = equatorColor.Evaluate(timeFraction);
        RenderSettings.ambientSkyColor = skyColor.Evaluate(timeFraction);
        sun.color  = sunColor.Evaluate(timeFraction);
    }
}
