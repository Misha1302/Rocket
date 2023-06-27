using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RButton : Button
{
    public bool IsPressing { get; private set; }

    public override void OnPointerDown(PointerEventData eventData)
    {
        IsPressing = true;
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        IsPressing = false;
        base.OnPointerUp(eventData);
    }
}