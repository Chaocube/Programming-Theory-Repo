using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
       [SerializeField] public TMP_Text textToDisplay;
       [SerializeField]private static int clicksCount = 0;
       public static int Clicks { 
            get{return clicksCount;}
            set{ clicksCount = value;}
            } // ENCAPSULATION
       
    public virtual void DisplayText ()
    {
        textToDisplay.SetText("Error!");
    } void OnMouseDown()
    {
        if (Click.Clicks <3)
        {Click.Clicks++;
        DisplayText() ; // ABSTRACTION
        }
        else
        {
            textToDisplay.SetText("Aren't you full?");
        }
    
    }
}
