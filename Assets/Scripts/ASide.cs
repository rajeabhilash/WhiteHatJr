using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ASide : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider _sliderANume;
    [SerializeField] private Slider _sliderADeno;
    [SerializeField] private Text _sliderNumText;
    [SerializeField] private Text _sliderDenText;
    [SerializeField] private RawImage _leftRaw;
    [SerializeField] private Text _aEquation;

    private float nume;
    private float deno;

    public GameObject prefab;
    public int numberOfObjects = 20;
    public float radius = 5f;

    void Start()
    {
        nume = 1;
        deno = 2;

        _sliderANume.onValueChanged.AddListener((v) =>{ nume = v; changeHappened(); });
        _sliderADeno.onValueChanged.AddListener((v) =>{ deno = v; changeHappened(); });
    }
    void changeHappened()
    {
        _sliderNumText.text = "Numerator = " + nume.ToString();
        _sliderDenText.text = "Denominator = " + deno.ToString();
        _aEquation.text = nume.ToString() + "\n-\n" + deno.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
