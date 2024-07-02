using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A05
{
    internal class MainMenu
    {
        RecipeManager recipeManager;

        public MainMenu()
        {
            recipeManager = new RecipeManager();
        }

        public void MainMenuUi()
        {
            Console.WriteLine("===== Recipe Manager =====");
            Console.WriteLine(
                "1: Add a recipe\n" +
                "2: View all recipes\n" +
                "3: Search recipes\n" +
                "4: Import recipe\n" +
                "5: Export recipe\n");

            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("===== Add Recipe =====");
                    Console.Write("Enter recipe name");
                    string name = Console.ReadLine();
                    Recipe recipe = new Recipe()
                    {
                        Id = Recipe.counter++,
                        Name = name
                    };
                    recipeManager.AddRecipe(recipe);

                    break;
                case 2:
                    Console.WriteLine("===== All Recipes =====");
                    List<Recipe> recipes = recipeManager.GetAllRecipes();
                    foreach (var r in recipes)
                    {
                        Console.WriteLine(r);
                    }
                    break;
                case 3:
                    Console.WriteLine("===== Search Recipes =====");
                    Console.Write("Enter a keyword: ");
                    string key = Console.ReadLine();
                    Console.WriteLine(recipeManager.SearchRecipes(key));
                    
                    break;
                case 4:
                    Console.WriteLine("===== Import Recipes =====");
                    ImportUi();
                    break;
                case 5:
                    Console.WriteLine("===== Export Recipes =====");
                    ExportUi();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            MainMenuUi();

        }

        public void ExportUi()
        {
            Console.WriteLine(
                "1: Export to JSON\n" +
                "2: Export to EXCEL\n" +
                "3: Main Menu\n"
                );

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile1 = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Data\JsonImportData.json");
            string sFile2 = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Data\ExportData.xlsx");
            string filePath1 = Path.GetFullPath(sFile1);
            string filePath2 = Path.GetFullPath(sFile2);

            if (choice == 1)
            {
                recipeManager.ExportRecipes("json", filePath1);
            }
            else if (choice == 2)
            {
                recipeManager.ExportRecipes("xlsx", filePath2);
            }
        }

        public void ImportUi()
        {
            Console.WriteLine(
                "1: Import from JSON\n" +
                "2: Import from EXCEL\n" +
                "3: Main Menu\n"
                );

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile1 = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Data\JsonImportData.json");
            string sFile2 = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Data\ExportData.xlsx");
            string filePath1 = Path.GetFullPath(sFile1);
            string filePath2 = Path.GetFullPath(sFile2);

            if (choice == 1)
            {
                recipeManager.ImportRecipes(filePath1);
            }
            else if (choice == 2)
            {
                recipeManager.ImportRecipes(filePath2);
            }
        }

        public void run()
        {
            MainMenuUi();
        }
    }
}
