using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Slider _sliderRed;
    public Slider _sliderGreen;
    public Slider _sliderBlue;
    public GameObject car;

    public Material[] materials;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        //car = GetComponent<MeshRenderer>().material;
        
    }


    private void Update()
    {
        Material currenetMaterial = car.GetComponent<Material>();
        currenetMaterial = materials[i];

        materials[i].color = new Color(_sliderRed.value, _sliderGreen.value, _sliderBlue.value);
        //car.GetComponent<Material>().color = new Color(_sliderRed.value, _sliderGreen.value, _sliderBlue.value);
        Debug.Log(materials.Length);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BtnNext();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BtnPrev();
        }
    }

    public void BtnNext()
    {
        if (i + 1 < materials.Length)
        {
            i++;
        }
    }

    public void BtnPrev()
    {
        if (i - 1 >= 0)
        {
            i--;
        }
    }
}
