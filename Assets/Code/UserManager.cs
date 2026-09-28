using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UserManager : MonoBehaviour
{
    private List<User> users = new List<User>();
    [SerializeField]
    private Transform UserListContent;
    [SerializeField]
    private GameObject UserPanelPrefab;
    private Dictionary<int, GameObject> panelPairs = new Dictionary<int, GameObject>();

    public void AddUser(string name, int age)
    {
        User u = new User(name, age);
        users.Add(u);

        // Instantiate prefab
        AddPanel(u);
    }

    private void AddPanel(User u)
    {
        GameObject userPanelInstance = Instantiate(UserPanelPrefab, UserListContent);
        // Change prefab values
        userPanelInstance.GetComponent<UserPanel>().SetUser(u);
        panelPairs.Add(u.ID, userPanelInstance.gameObject);
    }

    public void ShowUsers(Predicate<User> filterIn)
    {
        foreach (Transform child in UserListContent)
        {
            int key = panelPairs.FirstOrDefault(x => x.Value == child).Key;
            Destroy(child.gameObject);
            panelPairs.Remove(key);
        }

        foreach (User u in users)
        {
            if (filterIn(u))
            {
                AddPanel(u);
            }
        }
    }

    public void DeleteUser(int id)
    {
        User u = users.Find(user => user.ID == id);
        Destroy(panelPairs[u.ID]);
        panelPairs.Remove(u.ID);
        users.Remove(u);
    }
}
