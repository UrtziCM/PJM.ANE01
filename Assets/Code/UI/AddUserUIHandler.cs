using UnityEngine;

public class AddUserUIHandler : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField nameField;
    [SerializeField] private TMPro.TMP_InputField ageField;
    [SerializeField] private UserManager userManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TryAddUser()
    {
        if (nameField.text.Length <= 0 || !IsNumeric(ageField.text))
        {
            NotifyError();
            return;
        }
        if (int.TryParse(ageField.text, out int age))
            userManager.AddUser(nameField.text, age);
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
        StartCoroutine(FeedbackPanel.instance.PopForSecondsWithText("Could not create user", 1));
    }
}
