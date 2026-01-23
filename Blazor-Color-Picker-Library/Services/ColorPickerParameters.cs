namespace BlazorColorPicker;

public record ColorPickerParameters
{
    public string Title { get; init; } = string.Empty;
    public string ColorSelected { get; init; } = string.Empty;
    public string[] MyColorPallet { get; init; }
    public string OverwriteBackgroundColor { get; init; }
    public string? Style { get; init; } = null;

    /// <summary>
    /// When true and ColorSelected is not in the palette, the closest color will be highlighted.
    /// </summary>
    public bool FindClosestIfNotFound { get; init; } = false;
}
