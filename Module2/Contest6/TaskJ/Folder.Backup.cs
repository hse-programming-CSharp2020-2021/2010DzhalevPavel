using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

partial class Folder
{
    internal class Backup
    {
        List<File> backupFiles = new List<File>();

        public Backup(Folder folder)
        {
            foreach (var file in folder.files)
            {
                backupFiles.Add(file);
            }
        }


        public static void Restore(Folder folder, Backup backup)
        {
            folder.files.Clear();
            foreach (var file in backup.backupFiles)
            {
                folder.files.Add(file);
            }
        }

    }

    public void AddFile(string name, int size)
    {
        files.Add(new File(name,size));
    }
    public void RemoveFile(File file)
    {
        files.Remove(file);
    }

    public File this[int i]
    {
        get
        {
            if(i<0||i>=files.Count)
                throw new IndexOutOfRangeException("Not enough files or index less zero");
            return files[i];
        }
    } 

    public File this[string filename]
    {
        get
        {
            File result = null;
            foreach (var file in files)
            {
                if (file.Name == filename)
                    result = file;
            }
            
            if(result==null)
                throw new ArgumentException("File not found");
            return result;
        }
    }

    public override string ToString()
    {
        string[] result = new string[files.Count+1];
        result[0] = "Files in folder:";
        int i=1;
        foreach (var item in files)
        {
            result[i]=item.ToString();
            i++;
        }

        string r="";
        for (int j = 0; j < result.Length; j++)
        {
            r += result[j];
            if (j < result.Length-1)
                r += "\n";
        }

        return r;
    }
}

