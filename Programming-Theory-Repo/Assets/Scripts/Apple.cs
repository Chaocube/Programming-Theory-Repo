using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Click
{
    // Start is called before the first frame update
    public override void DisplayText ()
    {
        textToDisplay.SetText("Healthy!");
    }
}
