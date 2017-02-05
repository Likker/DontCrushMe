using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum Direction
{
    LEFT,
    RIGHT
};

public class PlayerController : Controller {

    private int incremtentor = 0;

    private Direction direction;
    public List<Vector3> positions;
    private int pos = 1;

    public Text debug;

    protected override void Animate()
    {
        
    }

    public override void Move(Direction dir)
    {
        debug.text = (++incremtentor).ToString();
        if (dir == Direction.LEFT && pos > 0)
            this.transform.localPosition = positions[--pos];
        if (dir == Direction.RIGHT && pos < 2)
            this.transform.localPosition = positions[++pos];
    }

    protected override void Start()
    {
        
    }

    protected override void Update()
    {
        
    }

}
