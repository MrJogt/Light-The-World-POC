using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManaScript : MonoBehaviour
{
    [SerializeField] Slider manaSlider;


    void Start()
    {
        StartCoroutine(ManaRegeneration());
    }

    void Update()
    {
        
    }



    IEnumerator ManaRegeneration()
    {
        yield return new WaitForSeconds(1f);
        while (manaSlider.value < 10)
        {
            manaSlider.value += 1;
            yield return new WaitForSeconds(1f);
        }
        
    }

}
