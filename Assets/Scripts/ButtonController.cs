using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Transform _maze;
    public float _speed;
    private int rotate;
    private void Start() {
    }
    public void OnRotationLeft(){
        rotate = 1;
    }
    public void OnRotationLeftStop(){
        rotate = 0;
    }
    public void OnRotationRight(){
        rotate = -1;
    }
    public void OnRotationRightStop(){
        rotate = 0;
    }
    private void Update() {
        if(rotate == -1){
            _maze.Rotate(0, 0, rotate * _speed * Time.deltaTime);
        }
        if(rotate == 1){
            _maze.Rotate(0, 0, rotate * -_speed * -Time.deltaTime);
        }
    }
}
