using UnityEngine;

public class CubeTransformator: MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _increaseSpeed;
    [SerializeField] private float _zoom;
    private Vector3 _currentScale;

    private void Update()
    {
        transform.Translate(Vector3.forward * _movementSpeed);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        _currentScale = transform.localScale;
        transform.localScale = new Vector3((_currentScale.x + _zoom) * _increaseSpeed,
            (_currentScale.y + _zoom) * _increaseSpeed, (_currentScale.z + _zoom) * _increaseSpeed);
    }
}
