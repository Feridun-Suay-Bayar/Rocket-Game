using Rocket.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Rocket.UIs
{

}
public class FuelSlider : MonoBehaviour
{
    Slider _slider;
    Fuel _fuel;
    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _fuel = FindObjectOfType<Fuel>();
    }
    private void Update()
    {
        _slider.value = _fuel.CurrentFuel;
    }

}
