//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EquipmentCatalog equipmentCatalog = new EquipmentCatalog();
            ProductCatalog productCatalog = new ProductCatalog();

            productCatalog.AddProductToCatalog("Café", 100);
            productCatalog.AddProductToCatalog("Leche", 200);
            productCatalog.AddProductToCatalog("Café con leche", 300);

            equipmentCatalog.AddEquipmentToCatalog("Cafetera", 1000);
            equipmentCatalog.AddEquipmentToCatalog("Hervidor", 2000);

            Recipe recipe = new Recipe();
            recipe.FinalProduct = productCatalog.GetProduct("Café con leche");
            recipe.AddStep(recipe.CreateStep(productCatalog.GetProduct("Café"), 100, equipmentCatalog.GetEquipment("Cafetera"), 120));
            recipe.AddStep(recipe.CreateStep(productCatalog.GetProduct("Leche"), 200, equipmentCatalog.GetEquipment("Hervidor"), 60));

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }
    }
}
