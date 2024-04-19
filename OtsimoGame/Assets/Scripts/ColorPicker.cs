using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour, IPointerClickHandler
{
    public static ColorPicker instence;
    public Color color;

    private void Start()
    {
        instence = this;
        color=Color.white;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        color = Pick(Camera.main.WorldToScreenPoint(eventData.position), GetComponent<Image>());
    }

    Color Pick(Vector2 screenPoint, Image imagePicker)
    {
        Vector2 point;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(imagePicker.rectTransform, screenPoint, Camera.main, out point);
        point += imagePicker.rectTransform.sizeDelta / 2;
        Texture2D texture = GetComponent<Image>().sprite.texture;
        Vector2Int mPoint = new Vector2Int((int)((texture.width * point.x) / imagePicker.rectTransform.sizeDelta.x)
            , (int)((texture.height * point.y) / imagePicker.rectTransform.sizeDelta.y));
        return texture.GetPixel(mPoint.x, mPoint.y);
    }
}
