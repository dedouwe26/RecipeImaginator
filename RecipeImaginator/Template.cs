using System.Collections.ObjectModel;
using SixLabors.ImageSharp;

namespace RecipeImaginator;
public record Coordinate(int X, int Y);
public class Template {
    public readonly Image BaseImage;
    public ReadOnlyDictionary<string, Coordinate> Slots;
    public Template(Image baseImage, Dictionary<string, Coordinate> slots) {
        BaseImage = baseImage;
        Slots = slots.AsReadOnly();
    }
}