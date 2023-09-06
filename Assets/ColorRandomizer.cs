using System;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    public Color[] customColors; // Array of custom colors

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Randomize the color when the object is instantiated
        RandomizeColor();
    }

    private void RandomizeColor()
    {
        // Generate a random color
        // Color randomColor = new Color(Random.value, Random.value, Random.value);

        int colorIndex = UnityEngine.Random.Range(0, customColors.Length);

        // Apply the random color to the sprite renderer
        //spriteRenderer.color = randomColor;

        // Apply the selected color to the sprite renderer
        spriteRenderer.color = customColors[colorIndex];
    }
}
