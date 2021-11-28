using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Divider : MonoBehaviour
{
    [SerializeField] private Slider _sliderANume;
    [SerializeField] private Slider _sliderADeno;

    public RawImage[] volla = new RawImage[5];
    private int nVal;
    private int dVal;

    void Start()
    {
        nVal = (int)_sliderANume.value;
        dVal = (int)_sliderADeno.value;
        divide();
        _sliderANume.onValueChanged.AddListener((v) => { nVal = (int)v; divide(); });
        _sliderADeno.onValueChanged.AddListener((v) => { dVal = (int)v; divide(); });
    }
    void divide()
    {
        for (int i = 0; i < volla.Length; i++)
        {
            if (dVal - 1 == i)
            {
                volla[i].gameObject.SetActive(true);
            }
            else
            {
                volla[i].gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
