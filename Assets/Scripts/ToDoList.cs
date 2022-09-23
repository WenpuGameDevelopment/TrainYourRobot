using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Windows;
using System.IO;
using System.Reflection;
using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using UnityEngine.UI;

[CreateAssetMenu (fileName = "ToDoList", menuName = "GameData/ToDoList")]
public class ToDoList : ScriptableObject
{
    public List<ToDoTask> tasks = new List<ToDoTask>();

    [System.Serializable]
    public class ToDoTask
    {
        public bool isDone;
        public string task;
    }
}
