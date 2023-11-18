using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class AddTodoHandler : MonoBehaviour
{
    private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    public GameObject todoList;


    public void CreateTodo()
    {
        Debug.Log("creating todo... ");
        var key = Convert.ToString((DateTime.UtcNow - UnixEpoch).TotalMilliseconds);
        todoList.transform.GetComponent<TodoListHandler>().CreateTodo(key, "example text");
    }
}
