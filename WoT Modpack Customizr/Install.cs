using System;
using System.Collections.Generic;
using System.IO;

namespace Mod_Pack_Customizr
{
    public class Install
    {
        private static string gamePath = "";
        private static List<string> modsList = new List<string>();

        // Initiates the copy process.
        public void startInstall(List<string> pathToMods, string pathToInstall)
        {
            modsList = pathToMods;
            gamePath = pathToInstall;

            //Copies all the directories and subdirectories under each path in modList.
            foreach (var path in modsList)
            {
                DirectoryInfo source = new DirectoryInfo(path);
                DirectoryInfo target = new DirectoryInfo(gamePath);
                CopyAllDirectories(source, target);
            }
        }

        // This method performs the actual installation of the mods to the target directory. It is essentially just copying the mods the user selects to the target directory.
        private static void CopyAllDirectories(DirectoryInfo source, DirectoryInfo target)
        {
            // Checks if directory exists.
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo file in source.GetFiles())
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, file.Name);    // For debugging purposes.
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAllDirectories(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}