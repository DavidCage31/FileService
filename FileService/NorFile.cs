using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FileService
{
    public class NorFile
    {
        private string text;
        private string path;
        private string name;

        public string Text { get { return text; } }
        public string Path { get { return path; } }
        public string Name { get { return name; } }

        public NorFile()
        {
            this.text = null;
            this.path = null;
            this.name = null;
        }
        public NorFile(string text, string name)
        {
            this.text = text;
            this.name= name;
            this.path = "";
        }
        public NorFile(string path)
        {
            this.path = "Files\\" + path + ".txt";

            if (!File.Exists(this.path))
            {
                File.Create(this.path).Close();                
                this.text = "";
            }
            else
                this.text = File.ReadAllText(this.path);
            this.name = path;
        }

        public string[] Find(string pattern)
        {
            Regex reg = new Regex(@pattern);

            List<string> allMatches = new List<string>();

            MatchCollection matches = reg.Matches(text);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    allMatches.Add(match.Value);

            }
            else
                allMatches.Add("Совпадений не найдено");

            return allMatches.ToArray();
        }

        public void Replace(string pattern, string target)
        {
            Regex reg = new Regex(pattern);
            this.text = reg.Replace(text, target);
        }

        public async void Rewrite(string NewText)
        {
            await File.WriteAllTextAsync(this.path, NewText);
        }

        public void Delete()
        {
            File.Delete(this.path);
        }
    }
}