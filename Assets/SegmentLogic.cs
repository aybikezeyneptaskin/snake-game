using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentLogic : MonoBehaviour
{
    public Snake snake;
    private SpriteRenderer sr;

    private float timerSnake;
    //private List<Color> colorList = new List<Color>();

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        snake = GameObject.Find("Snake").GetComponent<Snake>();
        //SetColorList();
    }

    private void Update()
    {
        if (snake.state == Snake.State.Dead)
        {
            //sr.color = new Color(1, 0, 0);
            timerSnake += Time.deltaTime;
            if(timerSnake > snake.colorChangeRateSnake)
            {
                //Debug.Log("here");
                sr.color = snake.colorList[snake.ind];
                
                //snake.ind = (snake.ind+1)%snake.count;
                timerSnake = 0;
            }
        }
    }

    /*private void SetColorList()
    {
        colorList.Add(Color.red);
        colorList.Add(Color.grey);
        count = colorList.Count;
    }*/
}
