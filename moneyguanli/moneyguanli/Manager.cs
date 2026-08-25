using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Class
{
    internal class Manager
    {
        private string Path { get; } = "./emp.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };

        //读取文件并反序列化为 List<Lei>，若文件不存在则返回空列表
        private List<Lei> Load()
        {
            if (!File.Exists(Path))
            return new List<Lei>();
            string jsonStr = File.ReadAllText(Path);
            return JsonSerializer.Deserialize<List<Lei>>(jsonStr);
        }

        // 将 List<Lei> 序列化并写入文件
        private void Save(List<Lei> data)
        {
            string resStr = JsonSerializer.Serialize(data, JsonOpt);
            File.WriteAllText(Path, resStr);
        }

        // 1. 新增员工
        public string Add(int Id, string Name, string Bumen, double Salary)
        {
            List<Lei> biao = Load(); // 使用封装的反序列化方法

            if (biao.Exists(e => e.Id == Id))
                return "新增失败，员工已存在";

            biao.Add(new Lei(Id, Name, Bumen, Salary));
            Save(biao); // 保存

            return "新增员工成功";
        }

        // 2. 查看全部员工
        public void All()
        {
            List<Lei> biao = Load();
            if (biao.Count == 0)
            {
                Console.WriteLine("没有员工信息，请先添加");
                return;
            }

            foreach (var emp in biao)
            {
                Console.WriteLine($"编号 : {emp.Id} -- 姓名 : {emp.Name} -- 部门 : {emp.Bumen} -- 工资 : {emp.Salary}");
            }
        }

        // 3. 根据编号调整薪资
        public void Tiaoxin(int id)
        {
            List<Lei> biao = Load();
            Lei target = biao.Find(e => e.Id == id);
            if (target == null)
            {
                Console.WriteLine("没有对应ID的员工");
                return;
            }

            Console.WriteLine("请输入修改后的薪资");
            double newSalary = double.Parse(Console.ReadLine());
            target.Salary = newSalary;

            Save(biao);
            Console.WriteLine("修改成功");
        }

        // 4. 根据编号删除员工
        public void Shanchu(int id)
        {
            List<Lei> biao = Load();
            int removedCount = biao.RemoveAll(e => e.Id == id);

            if (removedCount == 0)
            {
                Console.WriteLine("未找到该员工，删除失败");
                return;
            }

            Save(biao);
            Console.WriteLine("删除员工成功");
        }

        // 5. 按薪资筛选员工（工资大于多少）
        public void Shai(double minSalary)
        {
            List<Lei> biao = Load();
            var filtered = biao.FindAll(e => e.Salary > minSalary);

            if (filtered.Count == 0)
            {
                Console.WriteLine($"没有工资大于 {minSalary} 的员工");
                return;
            }

            Console.WriteLine($"工资大于 {minSalary} 的员工如下：");
            foreach (var emp in filtered)
            {
                Console.WriteLine($"编号 : {emp.Id} -- 姓名 : {emp.Name} -- 部门 : {emp.Bumen} -- 工资 : {emp.Salary}");
            }
        }
    }
}