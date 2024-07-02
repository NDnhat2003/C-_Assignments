using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using OfficeOpenXml;
using System.Data;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace NCTR.M.A05
{
    internal class RecipeManager
    {
        List<Recipe> recipes;

        public RecipeManager()
        {
            recipes = new List<Recipe>();
        }

        public virtual void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
        public virtual List<Recipe> GetAllRecipes()
        {
            return recipes;
        }
        public virtual Recipe SearchRecipes(string keyword)
        {
            foreach (var recipe in recipes)
            {
                if (recipe.Name == keyword) {  return recipe; }
            }
            return null;
        }
        public virtual void ImportRecipes(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.");
            }
            
            string extension = Path.GetExtension(filePath).ToLower();
            //Check extension
            if (extension == ".xlsx")
            {
                //Inport Excel File
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    int row = 2;
                    while (worksheet.Cells[row, 1].Value != null)
                    {
                        var recipe = new Recipe
                        {
                            Id = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                            Name = worksheet.Cells[row, 2].Value.ToString()
                        };
                      
                        recipes.Add(recipe);
                        row++;
                    }
                }
            }
            else if (extension == ".json")
            {
                //Import JSON file
                //string jsonString = File.ReadAllText(filePath);
                //recipes = JsonSerializer.Deserialize<List<Recipe>>(jsonString);

                string json = File.ReadAllText(filePath);
                recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
            }
            else
            {
                throw new Exception("Invalid type");
            }   
        }

        public virtual void ExportRecipes(string fileType, string filePath)
        {
            if (fileType == "json")
            { 

                string jsonString = System.Text.Json.JsonSerializer.Serialize(recipes);
                File.WriteAllText(filePath, jsonString);

            }
            else if (fileType == "xlsx")
            {
               

                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Name", typeof(string));

                foreach (var recipe in recipes)
                    table.Rows.Add(recipe.Id, recipe.Name);

                using (ExcelPackage pck = new ExcelPackage(filePath))
                {
                    ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet1");
                    ws.Cells["A1"].LoadFromDataTable(table, true);
                    pck.Save();
                }
            } else { throw new Exception("Invalid type"); }
        }
    }
}
