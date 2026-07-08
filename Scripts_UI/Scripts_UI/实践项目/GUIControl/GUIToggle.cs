using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GUIToggle : GUIControl
{
    public bool isSel;

    public event UnityAction<bool> changevalue;

    private bool isOldSel;
    protected override void StyleOff()
    {
        isSel = GUI.Toggle(guiPos.Pos, isSel, content);
        if (isOldSel != isSel)
        {
            changevalue?.Invoke(isSel);
            isOldSel = isSel;
        }
        
    }

    protected override void StyleOn()
    {
        isSel = GUI.Toggle(guiPos.Pos, isSel, content, style);
        if (isOldSel != isSel)
        {
            changevalue?.Invoke(isSel);
            isOldSel = isSel;
        }
    }

}
