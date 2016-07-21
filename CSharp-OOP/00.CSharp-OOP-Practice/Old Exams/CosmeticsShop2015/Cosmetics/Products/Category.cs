using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics.Engine
{
    public class Category : ICategory
    {
        private string name;
        public List<IProduct> Products { get; private set; }

        public Category(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, Const.maxCategoryNameLength, Const.minCategoryNameLength, string.Format("GlobalErrorMessages.InvalidStringLength", "Category name", Const.minCategoryNameLength, Const.maxCategoryNameLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to add to category"));
            Products.Add(cosmetics);
        }

        public string Print()
        {
            var str = new StringBuilder();
            str.AppendLine($"{this.Name} - {this.Products.Count} {(this.Products.Count == 1? "product" : "products")} in total");
            var sorted = this.Products
                .OrderBy(x => x.Brand)
                .ThenByDescending(x => x.Name);
            foreach (var item in this.Products)
            {
                str.AppendLine(item.Print());
            }

            return str.ToString().Trim();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to remove from category"));
            if (Products.Contains(cosmetics))
            {
                Products.Remove(cosmetics);
            }
            else
            {
                throw new InvalidOperationException($"Product {cosmetics.Name} does not exist in category {this.Name}");
            }
        }
    }
}