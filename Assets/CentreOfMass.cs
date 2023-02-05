using System.Collections;
using UnityEngine;

public class CentreOfMass : MonoBehaviour
{
    [SerializeField]
    private Transform _centreOfMass;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = _centreOfMass.localPosition;
    }
}
