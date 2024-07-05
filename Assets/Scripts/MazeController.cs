using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeController : MonoBehaviour
{
    [SerializeField] private Transform _tr;
    public Collider2D _ball;
    public GameObject _goal;
    private void Awake() {
        Vector3 _startPosition = new Vector3(-3.35f, 3.65f, 0);
        Instantiate(_ball, _startPosition, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Trigger");
    }
}
