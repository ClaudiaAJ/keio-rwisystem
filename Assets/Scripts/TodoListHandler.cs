using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TodoListHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InitializeTodoList();
    }

    public void InitializeTodoList()
    {
        //TODO: fetch from storage manager
        for (int i = 0; i < 5; i++)
        {
            CreateTodo(i.ToString(), "example title");
        }
    }

    public void CreateTodo(string key, string title)
    {
        //TODO: multiple type handling
        GameObject prefab = (GameObject)Resources.Load("PreFab/BasicTodo");
        GameObject todo = Instantiate(prefab);
        Debug.Log("created thingy");
        // this is the wrong way to do this. review
        // todo.transform.Find("Title").GetComponent<Text>().text = title;
        todo.transform.SetParent(transform);
        todo.transform.localScale = new Vector3(1, 1, 1);
    }
}
