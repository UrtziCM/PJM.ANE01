using UnityEngine;

public class AddUserUIHandler : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField nameField;
    [SerializeField] private TMPro.TMP_InputField ageField;
    [SerializeField] private UserManager userManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TryAddUser()
    {
        if (nameField.text.Length < 0 || !IsNumeric(ageField.text))
        {
            NotifyError();
            return;
        }
        
        userManager.AddUser(nameField.text, int.Parse(ageField.text));
    }


    private bool IsNumeric(string text)
    {
        foreach (char s in text)
        {
            if (!char.IsDigit(s)) return false;
        }
        return true;
    }

    private void NotifyError()
    {
        Debug.LogError("Could not create user");
    }
}
