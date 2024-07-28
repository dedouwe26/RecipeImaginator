using System.Collections.ObjectModel;
using SixLabors.ImageSharp;

namespace RecipeImaginator;

public class Recipe {
    public readonly Template Template;
    public readonly ReadOnlyDictionary<string, Item> Slots;
    public Recipe(Template template, Dictionary<string, Item> slots) {
        Template = template;
        Slots = slots.AsReadOnly();
    }
    public Image ToImage() {
        
    }
}