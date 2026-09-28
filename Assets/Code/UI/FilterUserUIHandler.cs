using System;
using UnityEngine;

public class FilterUserUIHandler : MonoBehaviour
{
    [SerializeField]
    private UserManager userManager;
    [SerializeField]
    private TMPro.TMP_InputField IDInputField;
    public void FilterUsers(Int32 value)
    {
        switch (value)
        {
            case 0: // None
                userManager.ShowUsers(u => true);
                break;
            case 1: // > 21
                userManager.ShowUsers(u => u.Age >= 18);
                break;
        }
    }
    public void FilterUsersByID()
    {
        if (int.TryParse(IDInputField.text, out int id))
            userManager.ShowUsers(u => u.ID == id);
    }
}
