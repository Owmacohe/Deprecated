using System;
using TMPro;
using UnityEngine;

public class ChoiceHover : MonoBehaviour
{
    TMP_Text text;
    
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    public void Enter()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0.5f);
    }
    
    public void Exit()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
    }
}
