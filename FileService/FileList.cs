using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileService
{
    public class FileList
    {
        private NorFile[] fs;
        private int size;

        public int Size { get { return fs.Length; } }

        public FileList()
        {
            this.fs = new NorFile[0];
            this.size = 0;
        }
        public FileList(NorFile[] fs)
        {
            this.fs = fs;
            this.size = fs.Length;
        }

        public NorFile this[int index]
        {
            get => fs[index];
            set => fs[index] = value;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach (NorFile file in this.fs)
                yield return file;
        }

        public void Add(NorFile file)
        {
            NorFile[] temp = this.fs;
            this.fs = new NorFile[++this.size];

            for (int i = 0; i < temp.Length; i++)
                this.fs[i] = temp[i];

            this.fs[this.size - 1] = file;
        }

        public void Remove(int indx)
        {
            NorFile[] temp = new NorFile[--this.size];
            int j = 0;

            for (int i = 0; i <= this.size; i++)
            {
                if (i == indx)
                    continue;
                temp[j++] = this.fs[i];
            }

            this.fs = temp;
        }
        public void Remove(NorFile file)
        {
            NorFile[] temp = new NorFile[--this.size];
            int j = 0;

            foreach (NorFile f in fs)
            {
                if (f == file)
                    continue;
                temp[j++] = f;
            }

            this.fs = temp;
        }

        public int CurrentFile(string fileName)
        {
            for (int i = 0; i  < this.size; i++)
                if (fs[i].Path == fileName)
                    return i;
            return -1;
        }

    }
}
