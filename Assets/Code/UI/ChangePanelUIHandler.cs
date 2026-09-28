using UnityEngine;

public class ChangePanelUIHandler : MonoBehaviour
{
    int mode = 0;
    [SerializeField] private GameObject[] panels;

    public void NextMode()
    {
        mode++;
        mode %= panels.Length;
        foreach (GameObject go in panels)
        {
            go.SetActive(false);
        }
        panels[mode].SetActive(true);

    }
}
