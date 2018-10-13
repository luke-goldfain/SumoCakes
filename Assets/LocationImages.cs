using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationImages : MonoBehaviour {
    public bool sliderMovementLeft;
    public bool sliderMovementRight;

    public Slider LocationSlider;
	// Use this for initialization
	void Start ()
    {
        LocationSlider.minValue = 0;
        LocationSlider.maxValue = 10;
        LocationSlider.wholeNumbers = true;
        LocationSlider.value = 5;
	}
	
	// Update is called once per frame
	void Update ()
    {
        SliderMovement();
        sliderMovementLeft = Input.GetKeyDown("a");
        sliderMovementRight = Input.GetKeyDown("d");
    }
    //Slider movement manipulates slider value to change pancake position
    //Can be changed to use when attacked is implemented
    private void SliderMovement()
    {
        if (sliderMovementLeft == true)
        {
            LocationSlider.value -= 1;

        }
        if (sliderMovementRight == true)
        {
            LocationSlider.value += 1;

        }
    }
}
