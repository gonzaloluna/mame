using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MameLibrary
{
    public class Util
    {
        /// <summary>
        /// Crear lista con el valor de game->name
        /// </summary>
        public static void Funcionalidad1(string xmlFilePath, string listaFilePath)
        {
            XDocument document = XDocument.Load(File.OpenRead(xmlFilePath));
            var fileStream = File.CreateText(listaFilePath);
            var objQuery = document.Element("menu").Elements("game").Attributes("name");
            objQuery.Select(x => x.Value).ToList<string>().ForEach(i => fileStream.WriteLine(i));
            fileStream.Close();
        }

        /// <summary>
        /// Crear archivos dummy
        /// </summary>
        /// <param name="fileInputPath"></param>
        /// <param name="fileOutputPath"></param>
        public static void Funcionalidad2(string listFilePath, string dummyFolderPath){

            var dummyList = File.ReadAllLines(listFilePath).Select(x => x + ".txt").ToList();

            dummyList.ForEach(x => File.CreateText(dummyFolderPath +"\\"+ x).Close());
        }

        /// <summary>
        /// Comparar directorio lista y crear sobra falta
        /// </summary>
        public static void Funcionalidad3(string listFilePath, string dummyFolderPath, string sobraFilePath, string faltaFilePath)
        {
            DirectoryInfo di = new DirectoryInfo(dummyFolderPath);
            FileInfo[] smFiles = di.GetFiles();
            var listaArchivosSinExtension = new List<string>();
            foreach (FileInfo fi in smFiles)
            {
                listaArchivosSinExtension.Add(Path.GetFileNameWithoutExtension(fi.Name));
            }

            var lista = File.ReadLines(listFilePath).ToList<string>();

            var falta = lista.Except(listaArchivosSinExtension).ToList();
            var faltaFileStream = File.CreateText(faltaFilePath);
            falta.ForEach(i => faltaFileStream.WriteLine(i));
            faltaFileStream.Close();

            var sobra = listaArchivosSinExtension.Except(lista).ToList();
            var sobraFileStream = File.CreateText(sobraFilePath);
            sobra.ForEach(i => sobraFileStream.WriteLine(i));
            sobraFileStream.Close();
        }
        /*
         * Funcionalidad 4. Necesitaría que al pasarle una lista.txt mueva (no copiar) los 
         * archivos que coinciden de un determinado directoria a otro de mi elección.
         * Si hay nombres en la lista, que no coinciden con ningún archivo, no debería hacer nada. 

        Ejemplo. En mi directorio fichines tengo lo siguientes archivos:
        AntiAircraft.png
        Breakout.txt
        Caca.jpg
        Culo.mp3

        La lista que le paso tiene el siguiente contenido:
        AntiAircraft
        Attack
        Breakout
        CleanSweep

        La salida en la carpeta destino debería ser:
        AntiAircraft.png
        Breakout.txt

        Los archivos remanentes en la carpeta fichines deberían ser:
        Caca.jpg
        Culo.mp3
        */
        //// <summary>
        /// Mover Archivos que coinciden en una lista
        /// </summary>
        public static void Funcionalidad4(string listFilePath, string folderToSearch, string matchesDestinatinoFolderPath)
        {
            var dummyList = File.ReadAllLines(listFilePath).ToList();
            DirectoryInfo dir = new DirectoryInfo(folderToSearch);
            FileInfo[] smFiles = dir.GetFiles();
            List<FileInfo> fileMatches = new List<FileInfo>();
            dummyList.ForEach(item => fileMatches.AddRange(dir.GetFiles(item)));
            dummyList.ForEach(item => fileMatches.AddRange(dir.GetFiles(item + ".*")));
            dummyList.ForEach(item => fileMatches.AddRange(dir.GetFiles(item + ".")));
            fileMatches.ForEach(item => item.MoveTo(matchesDestinatinoFolderPath + "\\" + item.Name));
        }

        //// <summary>
        /// Mover Archivos que no coinciden en una lista
        /// </summary>
        public static void Funcionalidad5(string listFilePath, string folderToSearch, string NoMatchesDestinatinoFolderPath)
        {

            var dummyList = File.ReadAllLines(listFilePath).ToList();
            DirectoryInfo di = new DirectoryInfo(folderToSearch);
            FileInfo[] smFiles = di.GetFiles();
            var listaArchivosSinExtension = new List<string>();
            var archivosAMover = new List<string>();
            foreach (FileInfo fi in smFiles)
            {
                if (!dummyList.Contains(Path.GetFileNameWithoutExtension(fi.Name)))
                {
                    archivosAMover.Add(fi.FullName);
                }
            }
            archivosAMover.ForEach(x=>File.Move(x,NoMatchesDestinatinoFolderPath + "\\" + (new FileInfo(x).Name)));


        }

    }
}
