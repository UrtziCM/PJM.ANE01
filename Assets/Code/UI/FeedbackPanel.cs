using System.Collections;
using UnityEngine;

public class FeedbackPanel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static FeedbackPanel instance;
    [SerializeField]
    private TMPro.TMP_Text textMesh;
    private void Start()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    public IEnumerator PopForSecondsWithText(string text, float time)
    {
        textMesh.text = text;
        gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
}
