using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Server.MirDatabase;
using Server.MirEnvir;

namespace Server.Utils
{
    public class JsonHelper
    {
        public static void WriteListToJsonFiles(List<MapInfo> list, string folderName)
        {
            foreach (var item in list)
            {
                if (!Directory.Exists(Path.Combine(Settings.ExportPath, folderName)))
                {
                    Directory.CreateDirectory(Path.Combine(Settings.ExportPath, folderName));
                };

                string itemFilePath = Path.Combine(Settings.ExportPath, folderName, item.FileName + ".json");

                try
                {
                    File.WriteAllText(itemFilePath, JsonConvert.SerializeObject(item, Formatting.Indented));
                }

                catch (Exception ex)
                {
                    MessageQueue.Instance.Enqueue($"地图文件 {item.FileName} Json化时爆错，报错信息 {ex.Message}");
                }
            }
            MessageQueue.Instance.Enqueue($"地图文件{list.Count}个导出成功");
        }
        public static void WriteListToJsonFiles(List<MonsterInfo> list, string folderName)
        {
            foreach (var item in list)
            {
                if (!Directory.Exists(Path.Combine(Settings.ExportPath, folderName)))
                {
                    Directory.CreateDirectory(Path.Combine(Settings.ExportPath, folderName));
                };

                string itemFilePath = Path.Combine(Settings.ExportPath, folderName, item.Name + ".json");

                try
                {
                    File.WriteAllText(itemFilePath, JsonConvert.SerializeObject(item, Formatting.Indented));
                }

                catch (Exception ex)
                {
                    MessageQueue.Instance.Enqueue($"怪物文件 {item.Name} Json化时爆错，报错信息 {ex.Message}");
                }
            }
            MessageQueue.Instance.Enqueue($"怪物文件{list.Count}个导出成功");
        }

        public static void WriteListToJsonFiles(List<ItemInfo> list, string folderName)
        {
            foreach (var item in list)
            {
                if (!Directory.Exists(Path.Combine(Settings.ExportPath, folderName)))
                {
                    Directory.CreateDirectory(Path.Combine(Settings.ExportPath, folderName));
                };

                string itemFilePath = Path.Combine(Settings.ExportPath, folderName, item.Name + ".json");

                try
                {
                    File.WriteAllText(itemFilePath, JsonConvert.SerializeObject(item, Formatting.Indented));
                }

                catch (Exception ex)
                {
                    MessageQueue.Instance.Enqueue($"物品文件 {item.Name} Json化时爆错，报错信息 {ex.Message}");
                }
            }
            MessageQueue.Instance.Enqueue($"物品文件{list.Count}个导出成功");
        }

        public static void WriteListToJsonFiles(List<QuestInfo> list, string folderName)
        {
            foreach (var item in list)
            {
                if (!Directory.Exists(Path.Combine(Settings.ExportPath, folderName)))
                {
                    Directory.CreateDirectory(Path.Combine(Settings.ExportPath, folderName));
                };

                string itemFilePath = Path.Combine(Settings.ExportPath, folderName, item.Name + ".json");

                try
                {
                    File.WriteAllText(itemFilePath, JsonConvert.SerializeObject(item, Formatting.Indented));
                }

                catch (Exception ex)
                {
                    MessageQueue.Instance.Enqueue($"任务文件 {item.Name} Json化时爆错，报错信息 {ex.Message}");
                }
            }
            MessageQueue.Instance.Enqueue($"任务文件{list.Count}个导出成功");
        }

        public static void WriteListToJsonFiles(List<NPCInfo> list, string folderName)
        {
            foreach (var item in list)
            {
                if (!Directory.Exists(Path.Combine(Settings.ExportPath, folderName)))
                {
                    Directory.CreateDirectory(Path.Combine(Settings.ExportPath, folderName));
                };

                string itemFilePath = Path.Combine(Settings.ExportPath, folderName, item.Name + ".json");

                try
                {
                    File.WriteAllText(itemFilePath, JsonConvert.SerializeObject(item, Formatting.Indented));
                }

                catch (Exception ex)
                {
                    MessageQueue.Instance.Enqueue($"Npc文件 {item.Name} Json化时爆错，报错信息 {ex.Message}");
                }
            }
            MessageQueue.Instance.Enqueue($"Npc文件{list.Count}个导出成功");
        }


        public static void WriteListToJsonFiles(List<GameShopItem> list, string folderName)
        {
            foreach (var item in list)
            {
                if (!Directory.Exists(Path.Combine(Settings.ExportPath, folderName)))
                {
                    Directory.CreateDirectory(Path.Combine(Settings.ExportPath, folderName));
                };

                string itemFilePath = Path.Combine(Settings.ExportPath, folderName, item.Info.Name + ".json");

                try
                {
                    File.WriteAllText(itemFilePath, JsonConvert.SerializeObject(item, Formatting.Indented));
                }

                catch (Exception ex)
                {
                    MessageQueue.Instance.Enqueue($"商城物品 {item.Info.Name} Json化时爆错，报错信息 {ex.Message}");
                }
            }
            MessageQueue.Instance.Enqueue($"商城物品{list.Count}个导出成功");
        }

        public static void WriteListToJsonFiles(List<ConquestGuildInfo> list, string folderName)
        {
            foreach (var item in list)
            {
                if (!Directory.Exists(Path.Combine(Settings.ExportPath, folderName)))
                {
                    Directory.CreateDirectory(Path.Combine(Settings.ExportPath, folderName));
                };

                string itemFilePath = Path.Combine(Settings.ExportPath, folderName, item.Info.Name + ".json");

                try
                {
                    File.WriteAllText(itemFilePath, JsonConvert.SerializeObject(item, Formatting.Indented));
                }

                catch (Exception ex)
                {
                    MessageQueue.Instance.Enqueue($"征服 {item.Info.Name} Json化时爆错，报错信息 {ex.Message}");
                }
            }
            MessageQueue.Instance.Enqueue($"征服文件{list.Count}个导出成功");
        }
    }
}
