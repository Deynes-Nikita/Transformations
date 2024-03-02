using UnityEngine;

public class ScaleUp : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed) * Time.deltaTime;
    }
}
