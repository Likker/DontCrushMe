using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    abstract protected void Start();
    abstract protected void Update();
    abstract public void Move(Direction direction);
    abstract protected void Animate();
}
