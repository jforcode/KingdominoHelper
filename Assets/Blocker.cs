using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker : MonoBehaviour
{

    bool blockerOn = false;

    private void OnMouseUp()
    {
        blockerOn = !blockerOn;
        var c = GetComponent<SpriteRenderer>().color;
        c.a = blockerOn ? 1 : 0;
        GetComponent<SpriteRenderer>().color = c;
    }
}
