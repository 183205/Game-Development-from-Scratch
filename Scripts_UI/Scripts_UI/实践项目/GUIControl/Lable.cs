using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lable : GUIControl
{
    protected override void StyleOff()
    {
        GUI.Label(guiPos.Pos, content);
    }

    protected override void StyleOn()
    {
        GUI.Label(guiPos.Pos, content,style);
    }

}
