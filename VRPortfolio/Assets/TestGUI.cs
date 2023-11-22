using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestGUI : MonoBehaviour
{

    [SerializeField]
    Material MetallicBlack;
    [SerializeField]
    Material MetallicGold;
    [SerializeField]
    Material MetallicGray;
    [SerializeField]
    Button button;
    [SerializeField]
    Slider slider;

    public Material sharedMaterial;
    public static int track;
    public Transform bulletSize;

    // Start is called before the first frame update
    void Start()
    {
        sharedMaterial = MetallicGold;
        bulletSize.localScale = new Vector3(0.02f, 0.02f, 0.02f);
        track = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed()
    {

        TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();

        if (sharedMaterial == MetallicBlack && track == 0)
        {
            sharedMaterial = MetallicGold;
            buttonText.text = "Gold";
            track = 1;
        }

        if (sharedMaterial == MetallicGold && track == 0) {
            sharedMaterial = MetallicGray;
            buttonText.text = "Gray";
            track = 1;
        }

        if (sharedMaterial == MetallicGray && track == 0)
        {
            sharedMaterial = MetallicBlack;
            buttonText.text = "Black";
            track = 1;
        }

        track = 0; 

    }

    public void sliderMoved()
    {
        if (slider.value >= 0.1) {
            Debug.Log(slider.value);
            bulletSize.localScale = new Vector3(slider.value * .05f, slider.value * .05f, slider.value * .05f);
        }
    }
}
