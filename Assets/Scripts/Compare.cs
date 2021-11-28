using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compare : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Toggle _compare;
    [SerializeField] private Text _aText;
    [SerializeField] private Text _bText;
    [SerializeField] private Slider _sliderBNume;
    [SerializeField] private Slider _sliderBDeno;
    [SerializeField] private Slider _sliderANume;
    [SerializeField] private Slider _sliderADeno;

    private float lside;
    private float rside;

    void Start()
    {
        _compare.onValueChanged.AddListener((isOn)=> {
            if (isOn){
                _aText.enabled = true;
                _bText.enabled = true;

                lside = _sliderANume.value * _sliderBDeno.value;
                rside = _sliderBNume.value * _sliderADeno.value;
                
                if(lside == rside){
                    _aText.text = "EQUAL";
                    _bText.text = "EQUAL";
                }
                else
                {
                    if (lside > rside){
                        _aText.text = "BIGGER";
                        _bText.text = "SMALLER";
                    }
                    else{
                        _aText.text = "SMALLER";
                        _bText.text = "BIGGER";
                    }
                }
            }
            else{
                _aText.enabled = false;
                _bText.enabled = false;
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
