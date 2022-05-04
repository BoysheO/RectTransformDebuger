using Sirenix.OdinInspector;
using UnityEngine;
[ExecuteInEditMode]
public class RectTransformDebuger : MonoBehaviour {
    
    private RectTransform RectTransform;

    [ShowInInspector] private Vector2 pivot {
        get => RectTransform.pivot;
        set => RectTransform.pivot = value;
    }

    [ShowInInspector] private Rect rect => RectTransform.rect;

    [ShowInInspector] private Vector2 anchoredPosition {
        get => RectTransform.anchoredPosition;
        set => RectTransform.anchoredPosition = value;
    }

    [ShowInInspector] private Vector2 anchorMax {
        get => RectTransform.anchorMax;
        set => RectTransform.anchorMax = value;
    }

    [ShowInInspector] private Vector2 anchorMin {
        get => RectTransform.anchorMin;
        set => RectTransform.anchorMin = value;
    }

    [ShowInInspector] private Vector2 offsetMax {
        get => RectTransform.offsetMax;
        set => RectTransform.offsetMax = value;
    }

    [ShowInInspector] private Vector2 offsetMin {
        get => RectTransform.offsetMin;
        set => RectTransform.offsetMin = value;
    }

    [ShowInInspector] private Vector2 sizeDelta {
        get => RectTransform.sizeDelta;
        set => RectTransform.sizeDelta = value;
    }

    [ShowInInspector] private Vector3 anchoredPosition3D {
        get => RectTransform.anchoredPosition3D;
        set => RectTransform.anchoredPosition3D = value;
    }

    [ShowInInspector] private Vector3 forward {
        get => RectTransform.forward;
        set => RectTransform.forward = value;
    }

    [ShowInInspector] private Vector3 position {
        get => RectTransform.position;
        set => RectTransform.position = value;
    }

    [ShowInInspector] private Vector3 localposition {
        get => RectTransform.localPosition;
        set => RectTransform.localPosition = value;
    }


    private void Awake()
    {
        RectTransform = GetComponent<RectTransform>();
    }
}