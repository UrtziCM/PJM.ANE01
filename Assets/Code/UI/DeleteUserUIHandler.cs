using UnityEngine;

public class DeleteUserUIHandler : MonoBehaviour
{
    [SerializeField] private UserManager userManager;
    [SerializeField] private TMPro.TMP_InputField IDInput;
    public void TryDeleteUser()
    {
        int targetID;
        if ((targetID = IsValidInput(IDInput.text)) != -1)
        {
            userManager.DeleteUser(targetID);
        }
    }
    private int IsValidInput(string text)
    {
        if (int.TryParse(text, out int idNum))
            return idNum;
        return -1;
    }
}
