using UnityEngine;
using UnityEngine.UI;

public class SwitchCanvasButton : MonoBehaviour
{
    [SerializeField]
    Canvas ThisCanvas;
    [SerializeField]
    Canvas TargetCanvas;

    public void OnClick()
    {
        ThisCanvas.enabled = false;
        TargetCanvas.enabled = true;
    }
}
