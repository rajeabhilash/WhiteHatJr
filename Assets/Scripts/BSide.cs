using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BSide : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider _sliderBNume;
    [SerializeField] private Slider _sliderBDeno;
    [SerializeField] private Text _sliderNumText;
    [SerializeField] private Text _sliderDenText;
    [SerializeField] private RawImage _rightRaw;
    [SerializeField] private Text _bEquation;

    private float nume;
    private float deno;

    void Start()
    {
        nume = 1;
        deno = 3;
        _sliderBNume.onValueChanged.AddListener((v) => { nume = v; changeHappened(); });
        _sliderBDeno.onValueChanged.AddListener((v) => { deno = v; changeHappened(); });
    }
    void changeHappened()
    {
        _sliderNumText.text = "Numerator = " + nume.ToString();
        _sliderDenText.text = "Denominator = " + deno.ToString();
        _bEquation.text = nume.ToString() + "\n-\n" + deno.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
