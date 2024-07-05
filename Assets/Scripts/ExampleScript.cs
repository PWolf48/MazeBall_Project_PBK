using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [SerializeField] private Transform _tr;
    [SerializeField] private GameObject _square;
    [SerializeField] private GameObject _spawnedObject;
    [SerializeField] private GameObject _destroyable;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;
    public float _spawnInterval;
    private float timer;
    public float _rotationSpeed;
    private float _rotationAngle;
    private void Start() {
        timer = 0;
    }
    private void Update() {
        timer += Time.deltaTime;

        if(Input.GetKey(KeyCode.RightArrow)){
            _rotationAngle -= Time.deltaTime * _rotationSpeed;
            Quaternion rotate = Quaternion.Euler(0, 0, _rotationAngle);
            _square.transform.rotation = rotate;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            _rotationAngle += Time.deltaTime * _rotationSpeed;
            Quaternion rotate = Quaternion.Euler(0, 0, _rotationAngle);
            _square.transform.rotation = rotate;
        }

        if(timer > _spawnInterval){
            Vector2 spawnArea = new Vector2(Random.Range(spawnAreaMin.x, spawnAreaMax.x), Random.Range(spawnAreaMin.y, spawnAreaMax.y));
            Instantiate(_spawnedObject, spawnArea, Quaternion.identity);
            timer = 0;
        }
    }
}
