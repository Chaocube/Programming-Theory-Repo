using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
       [SerializeField] public TMP_Text textToDisplay;
    public virtual void DisplayText ()
    {
        textToDisplay.SetText("Default");
    } void OnMouseDown()
    {
    DisplayText() ;
    }
}
