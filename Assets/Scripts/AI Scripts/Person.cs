﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "new Person", menuName = "Person")]
public class Person : ScriptableObject
{
    public bool handEaten = false;
    public bool atGate = false;
}
