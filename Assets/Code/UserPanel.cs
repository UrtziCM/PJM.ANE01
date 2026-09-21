using UnityEngine;

public class UserPanel : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text idTextMesh;
    [SerializeField]
    private TMPro.TMP_Text userTextMesh;
    [SerializeField]
    private TMPro.TMP_Text ageTextMesh;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetUser(User user)
    {
        idTextMesh.text = user.ID.ToString();
        userTextMesh.text = user.Name;
        ageTextMesh.text = user.Age.ToString();
    }
}
