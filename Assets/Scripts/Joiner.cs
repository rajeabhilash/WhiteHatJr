using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Joiner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider _slider;
    [SerializeField] private RawImage _leftRaw;
    [SerializeField] private RawImage _rightRaw;
    void Start()
    {
        _slider.onValueChanged.AddListener((val) =>
        {
            _leftRaw.transform.position = new Vector2((val * _rightRaw.transform.position.x) / 10,_leftRaw.transform.position.y);
            Debug.Log("X : " + _leftRaw.transform.position.x);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
