using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EjercicioPeliculas
{
    class DialogoService
    {
        public DialogoService()
        {

        }

        public string AbrirArchivoDialogo()
        {
            string ruta = "";
            // Configure open file dialog box
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document"; // Default file name
            dialog.DefaultExt = ".json"; // Default file extension
            dialog.Filter = "Json documents (.json)|*.json"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                ruta = dialog.FileName;
            }

            return ruta;
        }

        public void MensajeEstado()
        {

        }

        public string GuardarAchivoDialogo()
        {
            string ruta = "";
            // Configure save file dialog box
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.FileName = "Document"; // Default file name
            dialog.DefaultExt = ".json"; // Default file extension
            dialog.Filter = "Json documents (.json)|*.json"; // Filter files by extension

            // Show save file dialog box
            bool? result = dialog.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                ruta = Path.GetFullPath(dialog.FileName);
            }

            return ruta;
        }
    }
}
