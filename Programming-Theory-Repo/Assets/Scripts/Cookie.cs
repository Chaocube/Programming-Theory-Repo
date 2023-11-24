using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : Click // INHERITANCE
    // Start is called before the first frame update
{
        public override void DisplayText () // POLYMORPHISM
    {
        textToDisplay.SetText("Yep!");
    }
}
