using System.Collections.Generic;

namespace BreakfastApp
{
    public class Product
    {
        #region "Properties"
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Product(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }

        /// <summary>
        /// Add ingredient to principal product
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="cookingTime">Preparation time</param>
        public void AddIngredient(int id, string name, int cookingTime)
        {
            Ingredients.Add(new Ingredient() { ID = id, Name = name, CookingTimeMs = cookingTime });
        }

        /// <summary>
        /// Add ingredient to principal product
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="cookingTime">Preparation time</param>
        public void AddIngredient(string name, int cookingTime)
        {
            var index = Ingredients.Count;
            Ingredients.Add(new Ingredient() { ID = index, Name = name, CookingTimeMs = cookingTime });
        }
       
    }   
}
