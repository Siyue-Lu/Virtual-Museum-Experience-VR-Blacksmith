using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    [SerializeField]
    private float _interval = 0.5f;

    [SerializeField]
    private Material _originalMaterial;

    [SerializeField]
    private Material _highlightMaterial;

    private Renderer highlightRenderer;

    private bool isSelected = false;
    private bool isHighlighted = false;

    void Start()
    {
        highlightRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (isSelected && !isHighlighted)
        {
            isHighlighted = true;
            StartCoroutine(Highlight());
        }
        if (!isSelected)
        {
            StopAllCoroutines();
            highlightRenderer.material = _originalMaterial;
            isHighlighted = false;
        }
    }

    public void HighlightOn()
    {
        isSelected = true;
    }

    public void HighlightOff()
    {
        isSelected = false;
    }

    private IEnumerator Highlight()
    {
        while (true)
        {
            highlightRenderer.material = _highlightMaterial;
            yield return new WaitForSeconds(_interval);
            highlightRenderer.material = _originalMaterial;
            yield return new WaitForSeconds(_interval);
        }
    }
}
