using UnityEngine;

public class CapsuleEnlarger: MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;
    [SerializeField] private float _zoom;
    private Vector3 _currentScale;

    private void Update()
    {
        _currentScale = transform.localScale;
        transform.localScale = new Vector3((_currentScale.x + _zoom) * _increaseSpeed,
            (_currentScale.y + _zoom) * _increaseSpeed, (_currentScale.z + _zoom ) * _increaseSpeed);
    }
}
