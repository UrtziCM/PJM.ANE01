using System;
using UnityEngine;

public class FilterUserUIHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void FilterUsers(Int32 value)
    {
        switch (value)
        {
            case 0: // None
                break;
            case 1: // > 21
                break;
        }
    }
}
