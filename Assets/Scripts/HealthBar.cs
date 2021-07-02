using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Color lowHealth;
    public Color highHealth;
    public Vector3 offset;

    void Start()
    {
        
    }

    public void UpdateHealth(int curHp, int maxHp)
    {
        slider.gameObject.SetActive(curHp < maxHp);
        slider.value = curHp;
        slider.maxValue = maxHp;

        //slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(lowHealth, highHealth, slider.normalizedValue);
    }

    // Update is called once per frame
    void Update()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
    }
}
