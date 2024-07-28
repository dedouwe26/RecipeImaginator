using SixLabors.ImageSharp;

namespace RecipeImaginator;

public class Item {
    public readonly string Name;
    public readonly Image Image;
    public Item(string name, Image image, int width = 16, int height = 16, Coordinate? offset) {
        Name = name;
        // TODO: Image processing
    }
}