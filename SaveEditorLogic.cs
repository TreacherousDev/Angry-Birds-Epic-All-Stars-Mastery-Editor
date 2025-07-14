using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace AngryBirdsEpicAllStarsSaveEditor
{
    public static class SaveEditorLogic
    {
        public static PlayerData PlayerDataObject;
        public static string PlayerDataBase64;
        public static string loadedPath;

        public static void LoadFile(string filePath)
        {
            PlayerDataBase64 = File.ReadAllText(filePath).Trim();
            loadedPath = filePath;
            PlayerDataObject = DeserializeBase64<PlayerData>(PlayerDataBase64);
        }

        public static void SaveToJson(string outputPath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            string json = JsonSerializer.Serialize(PlayerDataObject, options);
            File.WriteAllText(outputPath, json);
        }

        public static T DeserializeBase64<T>(string data) where T : class
        {
            using (var stream = new MemoryStream(Convert.FromBase64String(Uri.UnescapeDataString(data))))
            {
                return Serializer.Deserialize<T>(stream);
            }
        }

        public static string SerializeToBase64<T>(T data) where T : class
        {
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, data);
                return Convert.ToBase64String(stream.ToArray());
            }
        }

        public static void SaveToBase64File(string filePath,
        DataGridView redGrid,
        DataGridView chuckGrid,
        DataGridView matildaGrid,
        DataGridView bombGrid,
        DataGridView bluesGrid)
        {
            var allItems = new List<ClassItemData>();

            // Helper to extract rows from each grid
            void ReadGrid(DataGridView grid)
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue; // skip empty row

                    string name = row.Cells[0].Value?.ToString();
                    int level = int.TryParse(row.Cells[1].Value?.ToString(), out int l) ? l : 1;

                    // Find original NameId from display name
                    string nameId = MainForm.ClassNameLookup.FirstOrDefault(kv => kv.Value == name).Key ?? name;

                    allItems.Add(new ClassItemData
                    {
                        NameId = nameId,
                        Level = level,
                        // Optional: Keep other fields from old data
                        Value = 0,
                        Quality = 0,
                        IsNew = false,
                        ExperienceForNextLevel = 0
                    });
                }
            }

            // Read all grids
            ReadGrid(redGrid);
            ReadGrid(chuckGrid);
            ReadGrid(matildaGrid);
            ReadGrid(bombGrid);
            ReadGrid(bluesGrid);

            // Update PlayerData object
            SaveEditorLogic.PlayerDataObject.Inventory.ClassItems = allItems;

            // Serialize and save
            string base64 = SaveEditorLogic.SerializeToBase64(SaveEditorLogic.PlayerDataObject);

            File.WriteAllText(filePath, base64);
        }
    }
}