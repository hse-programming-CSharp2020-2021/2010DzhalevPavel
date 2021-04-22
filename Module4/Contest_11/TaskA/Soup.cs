using System;

public class Soup
{
    public Ingredient[] Ingredients { get; set; }

    public Soup(Ingredient[] ingredients)
    {
        Ingredients = ingredients;
        WillEat = true;
        foreach (var ingredient in Ingredients)
        {
            if (ingredient.GetType() == typeof(Meat))
            {
                var cuurentIngredient = (Meat) ingredient;
                if (!cuurentIngredient.IsTasty)
                    WillEat = false;
            }
            else
            {
                var cuurentIngredient = (Vegetable) ingredient;
                if (cuurentIngredient.IsAllergicTo)
                    WillEat = false;
            }
        }
    }

    public bool WillEat { get; set; }

}