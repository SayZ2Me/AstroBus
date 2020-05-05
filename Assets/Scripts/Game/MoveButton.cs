using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    PlayerController Player;
    [SerializeField]
    float Speed;
    bool Pressed;
    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
    void Update()
    {
        if (Pressed)
        {
            Player.Pos -= Speed;
        }
    }
}