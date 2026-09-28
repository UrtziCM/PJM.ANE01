using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DeleteUserUIHandler : MonoBehaviour
{
    [SerializeField] private UserManager userManager;
    [SerializeField] private TMPro.TMP_InputField IDInput;
    [SerializeField] private Slider slider;
    [SerializeField] private GameObject countdownPanel;
    public void TryDeleteUser()
    {
        int targetID;
        if ((targetID = IsValidInput(IDInput.text)) != -1)
        {
            slider.value = 1;

            StartCoroutine(FakeProgressBar());

            userManager.DeleteUser(targetID);
        }
        else
        {
            StartCoroutine(FeedbackPanel.instance.PopForSecondsWithText("Invalid input on field: ID or does not exist", 1));
        }
    }

    private IEnumerator FakeProgressBar()
    {
        countdownPanel.SetActive(true);
        while (slider.value > 0)
        {
            slider.value -= Time.deltaTime * .33f;
            yield return null;
        }
        countdownPanel.SetActive(false);

    }
    private int IsValidInput(string text)
    {
        if (int.TryParse(text, out int idNum))
            return idNum;
        return -1;
    }
}
