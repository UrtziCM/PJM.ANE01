using System.Collections.Generic;
using UnityEngine;

public class UserManager : MonoBehaviour
{
    private List<User> users = new List<User>();
    [SerializeField]
    private Transform UserListContent;
    [SerializeField]
    private GameObject UserPanelPrefab;


    private void AddUser(string name, int age)
    {
        User u = new User(name, age);
        users.Add(u);

        // Instantiate prefab
        GameObject userPanelInstance = Instantiate(UserPanelPrefab, UserListContent);
        // Change prefab values
        userPanelInstance.GetComponent<UserPanel>().SetUser(u);

    }

    private void Awake()
    {
        
    }

    private void Start()
    {
        // Test
        for (int i = 0; i < 100; i++)
            AddUser(Random.value.ToString(), Random.Range(0, 99));
    }
}
